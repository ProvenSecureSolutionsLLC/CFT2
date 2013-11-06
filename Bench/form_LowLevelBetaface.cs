using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Http;

using System.IO.Ports;

using System.Net.Sockets;
using System.Xml.Serialization;

namespace Bench
{
    public partial class form_LowLevelBetaface : Form
    {

        public string logstring = "";

        public form_LowLevelBetaface()
        {
            InitializeComponent();
        }

        public void clearlog()
        {
            logstring = "";
            tb_response.Text = "";
        }

        // given an image file, assume it is in a folder that is unique to a user
        // find all *.*.*.*.faceuid files
        public static List<string> GET_my_faceuid_filenames(string parmfilename)
        {

            string startFolder = Path.GetDirectoryName(parmfilename);

            // Take a snapshot of the file system.
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(startFolder);

            // This method assumes that the application has discovery permissions 
            // for all folders under the specified path.
            IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            //Create the query
            IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.Extension == ".faceuid"
                orderby file.Name
                select file;

            List<string> retval = new List<string>();

            foreach (System.IO.FileInfo fi in fileQuery)
            {
                retval.Add(fi.FullName);
            }

            return retval;
        }

        // given an image filename
        // call GET_my_faceuid_filenames to get list of all faceuid files in the folder the file is in
        // now, open all those files and get each faceuid of of them and return a list of the faceuids themselves
        public static List<string> GET_my_faceuids(string parmfilename)
        {
            if (parmfilename == "")
            {
                return null;
            }

            List<string> jj = GET_my_faceuid_filenames(parmfilename);

            List<string> faceuids = new List<string>();

//            tb_response.Text = "Find faceuids for the path of: " + Path.GetDirectoryName(filename) + "\r\n";
//            tb_response.AppendText("-----------------------------------------------------\r\n");

            foreach (string s in jj)
            {
//                tb_response.AppendText(s + "\r\n");
                StreamReader sr = new StreamReader(s);
                string ts = sr.ReadToEnd();
                faceuids.Add(ts);
//                tb_response.AppendText("     faceuid: " + ts + "\r\n");
                sr.Close();
            }

            return faceuids;
        }


        public void log(string s)
        {
            logstring += s + "\r\n";
            //tb_response.AppendText(s + "\r\n");
        }


        static byte[] ReadFile(string strFilePath)
        {
            if (!File.Exists(strFilePath))
            {
                return null;
            };

            FileInfo img = new FileInfo(strFilePath);
            byte[] data = null;
            try
            {
                using (FileStream fs = img.OpenRead())
                {
                    if (null != fs)
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            data = br.ReadBytes((Int32)fs.Length);
                            br.Close();
                        };
                        fs.Close();
                    }
                };
            }
            catch { };

            return data;
        }

        public void PrintUsage()
        {
            log("Usage: BetafaceWebServiceTest <webservce url> <username> <password>");
            log("                              upload <filepath or url 1> [filepath or url 2] [filepath or url 3]...");
            log("                              recognize <face GUID> targets recognize <face GUID or personname@namespace or all@namespace> [face GUID or personname@namespace or all@namespace] ...");
        }





        public void doit(string[] args)
        {
            if (args.Length < 5)
            {
                PrintUsage();
                return;
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // connect to webservice
            
            log("Connecting to webservice...");

            int iArgIdx = 0;
            string ServiceUri = args[iArgIdx++];
            string Username = args[iArgIdx++];
            string Password = args[iArgIdx++];
            string Command = args[iArgIdx++].ToLowerInvariant();

            HttpClient client = new HttpClient(ServiceUri);
            
            if (Command == "upload")
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // upload images

                log("Uploading images...");

                Dictionary<Guid, string> images = new Dictionary<Guid, string>();

                for (int i = iArgIdx; i < args.Length; i++)
                {
                    if (!String.IsNullOrEmpty(args[i]))
                    {
                        if (args[i].Substring(0, 5) == "http:")
                        {
                            log("test transfer via url");

                            //transfer from url
                            ImageRequestUrl request = new ImageRequestUrl();
                            request.api_key = Username;
                            request.api_secret = Password;
                            request.image_url = args[i];

                            HttpContent body = HttpContentExtensions.CreateXmlSerializable(request);
                            System.Net.ServicePointManager.Expect100Continue = false;

                            using (HttpResponseMessage response = client.Post("UploadNewImage_Url", body))
                            {
                                // Throws an exception if not OK 
                                response.EnsureStatusIsSuccessful();

                                BetafaceImageResponse ret = response.Content.ReadAsXmlSerializable<BetafaceImageResponse>();
                                if (ret.int_response == 0)
                                {
                                    images.Add(new Guid(ret.img_uid), args[i]);
                                    log("transfer ok");
                                }
                                else
                                {
                                    log("error " + ret.int_response + " " + ret.string_response);
                                };
                            }
                        }
                        else if (File.Exists(args[i]))
                        {
                            byte[] data = ReadFile(args[i]);
                            if (null != data)
                            {
                                log("transfer file " + args[i]);

                                //transfer file
                                ImageRequestBinary request = new ImageRequestBinary();
                                request.api_key = Username;
                                request.api_secret = Password;
                                request.imagefile_data = Convert.ToBase64String(data);
                                request.original_filename = args[i];

                                HttpContent body = HttpContentExtensions.CreateXmlSerializable(request);
                                System.Net.ServicePointManager.Expect100Continue = false;

                                using (HttpResponseMessage response = client.Post("UploadNewImage_File", body))
                                {
                                    // Throws an exception if not OK 
                                    response.EnsureStatusIsSuccessful();

                                    BetafaceImageResponse ret = response.Content.ReadAsXmlSerializable<BetafaceImageResponse>();
                                    if (ret.int_response == 0)
                                    {
                                        Guid g = new Guid(ret.img_uid);
                                        string orig = args[i];

                                        images.Add(g,orig);//new Guid(ret.img_uid), args[i]);
                                        log("Original: " + orig);
                                        log("  Assigned Guid: " + g.ToString());
                                        log("  Transfer ok");
                                    }
                                    else
                                    {
                                        log("error " + ret.int_response + " " + ret.string_response);
                                    };
                                }
                            };
                        }
                        else
                        {
                            log("File not found " + args[i]);
                        };
                    };
                };

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // retrieve results

                log("Waiting for results...");
                while (images.Count > 0)
                {
                    for (int i = 0; i < images.Count; i++)
                    {
                        ImageInfoRequestUid request = new ImageInfoRequestUid();
                        request.api_key = Username;
                        request.api_secret = Password;
                        request.img_uid = images.ElementAt(i).Key.ToString();

                        HttpContent body = HttpContentExtensions.CreateXmlSerializable(request);
                        System.Net.ServicePointManager.Expect100Continue = false;

                        using (HttpResponseMessage response = client.Post("GetImageInfo", body))
                        {
                            // Throws an exception if not OK 
                            response.EnsureStatusIsSuccessful();

                            response.Content.LoadIntoBuffer();
                            string str = response.Content.ReadAsString();

                            BetafaceImageInfoResponse ret = response.Content.ReadAsXmlSerializable<BetafaceImageInfoResponse>();
                            if (ret.int_response < 0)
                            {
                                log("error " + ret.int_response + " " + ret.string_response);
                                images.Remove(images.ElementAt(i).Key);
                                break;
                            }
                            else if (ret.int_response == 0)
                            {
                                string strResI = images.ElementAt(i).Key.ToString() + ".xml";
                                log("writing result to " + strResI);
                                using (StreamWriter sw = new StreamWriter(strResI))
                                {
                                    sw.WriteLine(str);
                                }

                                if (null == ret.faces.FaceInfo)
                                {
                                    log(images.ElementAt(i).Value + " - no faces found");
                                }
                                else
                                {
                                    log(images.ElementAt(i).Value + " - " + ret.faces.FaceInfo.Length + " faces found");
                                    for (int j = 0; j < ret.faces.FaceInfo.Length; j++)
                                    {
                                        log("face " + j + " score:" + ret.faces.FaceInfo[j].score + " x:" + ret.faces.FaceInfo[j].x + " y:" + ret.faces.FaceInfo[j].y + " w:" + ret.faces.FaceInfo[j].width + " h:" + ret.faces.FaceInfo[j].height + " a:" + ret.faces.FaceInfo[j].angle);

                                        string strResF = images.ElementAt(i).Key + "_" + ret.faces.FaceInfo[j].uid.ToString();

                                        //retrieve cropped face image
                                        FaceRequestId face_request = new FaceRequestId();
                                        face_request.api_key = Username;
                                        face_request.api_secret = Password;
                                        face_request.face_uid = ret.faces.FaceInfo[j].uid.ToString();

                                        HttpContent face_request_body = HttpContentExtensions.CreateXmlSerializable(face_request);
                                        System.Net.ServicePointManager.Expect100Continue = false;

                                        using (HttpResponseMessage resp_faceimage = client.Post("GetFaceImage", face_request_body))
                                        {
                                            // Throws an exception if not OK 
                                            resp_faceimage.EnsureStatusIsSuccessful();

                                            resp_faceimage.Content.LoadIntoBuffer();
                                            string str2 = resp_faceimage.Content.ReadAsString();

                                            BetafaceFaceImageResponse ret_faceimage = resp_faceimage.Content.ReadAsXmlSerializable<BetafaceFaceImageResponse>();
                                            if (ret.int_response == 0)
                                            {
                                                if (null != ret_faceimage.face_image)
                                                {
                                                    log("faceuid is: " + ret_faceimage.uid);
                                                    log("writing face image to " + strResF + ".jpg");
                                                    File.WriteAllBytes(strResF + ".jpg", ret_faceimage.face_image);
                                                }
                                            }
                                        }
                                    }
                                }
                                images.Remove(images.ElementAt(i).Key);
                                break;
                            };
                        }
                    };
                    Thread.Sleep(500);
                };
            }
            else if (Command == "recognize")
            {
                System.Collections.ArrayList al_guids = new System.Collections.ArrayList();
                for (; iArgIdx < args.Length; iArgIdx++)
                {
                    Guid g;
                    if (!String.IsNullOrEmpty(args[iArgIdx]))
                    {
                        if (args[iArgIdx] == "targets")
                        {
                            break;
                        }

                        if (Guid.TryParse(args[iArgIdx], out g))
                        {
                            al_guids.Add(args[iArgIdx]);
                        }
                    }
                }
                if (al_guids.Count == 0)
                {
                    log("no faces guids");
                    return;
                }
                System.Collections.ArrayList al_targets = new System.Collections.ArrayList();
                for (iArgIdx++; iArgIdx < args.Length; iArgIdx++)
                {
                    //Guid g;
                    if (!String.IsNullOrEmpty(args[iArgIdx]))
                    {
                        al_targets.Add(args[iArgIdx]);
                    }
                }
                if (al_targets.Count == 0)
                {
                    log("no face ids, persons or namespaces");
                    return;
                }

                //Send recognize request

                FacesRecognizeRequest recognizeRequest = new FacesRecognizeRequest();
                recognizeRequest.api_key = Username;
                recognizeRequest.api_secret = Password;
                recognizeRequest.faces_uids = (string[])al_guids.ToArray(typeof(string));
                recognizeRequest.targets = (string[])al_targets.ToArray(typeof(string));

                Guid recognize_request_id = Guid.Empty;

                HttpContent body = HttpContentExtensions.CreateXmlSerializable(recognizeRequest);
                System.Net.ServicePointManager.Expect100Continue = false;

                using (HttpResponseMessage response = client.Post("Faces_Recognize", body))
                {
                    // Throws an exception if not OK 
                    response.EnsureStatusIsSuccessful();

                    BetafaceRecognizeRequestResponse ret = response.Content.ReadAsXmlSerializable<BetafaceRecognizeRequestResponse>();
                    if (ret.int_response == 0)
                    {
                        recognize_request_id = new Guid(ret.recognize_uid);
                        log("recognize request sent, uid:" + recognize_request_id.ToString());
                    }
                    else
                    {
                        log("error sending recognize request " + ret.int_response + "\n" + ret.string_response);
                    };
                }

                //wait for result
                if (recognize_request_id != Guid.Empty)
                {
                    log("waiting for recognize result");

                    while (true)
                    {
                        RecognizeResultRequest compareResultRequest = new RecognizeResultRequest();
                        compareResultRequest.api_key = Username;
                        compareResultRequest.api_secret = Password;
                        compareResultRequest.recognize_uid = recognize_request_id.ToString();

                        HttpContent compareResultRequest_body = HttpContentExtensions.CreateXmlSerializable(compareResultRequest);
                        System.Net.ServicePointManager.Expect100Continue = false;
                        try
                        {
                            using (HttpResponseMessage response = client.Post("GetRecognizeResult", compareResultRequest_body))
                            {
                                // Throws an exception if not OK 
                                response.EnsureStatusIsSuccessful();

                                response.Content.LoadIntoBuffer();
                                string str = response.Content.ReadAsString();

                                BetafaceRecognizeResponse ret = response.Content.ReadAsXmlSerializable<BetafaceRecognizeResponse>();
                                if (ret.int_response < 0)
                                {
                                    log("error " + ret.int_response + " " + ret.string_response);
                                    break;
                                }
                                else if (ret.int_response == 0)
                                {
                                    //string strRes = "recognize_" + recognize_request_id.ToString() + ".txt";
                                    //log("writing result to " + strRes);
                                    //using (StreamWriter sw = new StreamWriter(strRes))
                                    //{
                                    log("Request");
                                    foreach (string g in recognizeRequest.faces_uids)
                                    {
                                        log(g);
                                    };
                                    log("");
                                    log("Response");

                                    foreach (BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfo mi in ret.faces_matches.FaceRecognizeInfo)
                                    {
                                        log("recognizing " + mi.face_uid);
                                        log("closest matches");
                                        foreach (BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfoMatchesPersonMatchInfo pmi in mi.matches.PersonMatchInfo)
                                        {
                                            float d = pmi.confidence;
                                            if (d == float.NaN) { d = 0; }
                                            if ((d == 0) && (pmi.is_match)) { d = 1; }
                                            //log(pmi.person_name + " " + pmi.confidence + " " + pmi.is_match + " " + pmi.face_uid);
                                            log("score: " + pmi.confidence); // + " " + pmi.is_match + " " + pmi.face_uid);
                                        }
                                    }
                                    //}

                                    //log(str);
                                    break;
                                };
                            };
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Exception getting HTTP Response: "+e.Message);
                        }
                    
                        Thread.Sleep(500);
                    };
                }
            }
            else
            {
                log("Unrecognized command");

                PrintUsage();
            }

            return;
        }

        private void btn_pickfile_Click(object sender, EventArgs e)
        {
            string retval = "";

            retval += "Default";

            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            string basedir = System.IO.Path.GetDirectoryName(a.Location);

            retval = basedir + "\\UserData\\" + retval;

            openFileDialog1.InitialDirectory = retval;
            DialogResult res = openFileDialog1.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                tb_selectedfile.Text = openFileDialog1.FileName;
            }

        }


        // upload the image file to betaface
        // write a file  filename.faceuid containing the face uid found in the image - HOPEFULLY ONLY ONE !!!
        public Boolean upload(string filename)
        {
            string[] parms;

            clearlog();

            parms = new string[15];

            string popdir = System.IO.Directory.GetCurrentDirectory();
            string folder = Path.GetDirectoryName(filename);
            string faceuidfilename = "";

            try
            {
                System.IO.Directory.SetCurrentDirectory(folder);

                parms[0] = "http://betafaceapi.com/service.svc/";  // service end point
                parms[1] = "d45fd466-51e2-4701-8da8-04351c872236"; // service user id
                parms[2] = "171e8465-f548-401d-b63b-caf0dc28df5f"; // service user password
                parms[3] = "upload";                               // command to execute
                parms[4] = filename;

                doit(parms);  // upload

                Application.DoEvents();
                string tmp = logstring; // tb_response.Text;

                string[] split = tmp.Split(new char[] { '\n' });
                // faceuid is: 2157ab2d-1db7-11e3-b11e-80ee734cfa77
                string faceuid = "";
                foreach (string s in split)
                {

                    if (s.Trim().StartsWith("faceuid is:"))
                    {
                        faceuid = s.Remove(0, 12);
                        faceuid = faceuid.Trim();
                        //MessageBox.Show("Face uid: " + faceuid);
                        //log("Scanning Faceuid is: " + faceuid);
                        faceuidfilename = filename + ".faceuid";

                        // go ahead and get the latest faceuid - we may have had to repeat the process
                        // therefore we may have a new faceuid for the same image if they cleaned out
                        // their repository at betaface.com
                        // ---------------------------------------
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(faceuidfilename);
                        sw.Write(faceuid);
                        sw.Close();
                    }
                }
            }
            finally
            {
                System.IO.Directory.SetCurrentDirectory(popdir);
            }





            if (faceuidfilename != "") { return true; }
            else { return false; }
        }


        // HERE

        // FOR a given image file .bmp
        // FIND the image file.bmp.faceuid file
        // READ the faceuid
        // Tell betaface to RECOGNIZE this face uid
        // - clearly, an upload of the image must have already taken place to get the .faceuid 
        public string recognize(string filename)
        {
            string[] parms;
            parms = new string[100];

            string tmpfilename = filename + ".faceuid";
            string faceuid = "";
            string retval = "";

            if (!File.Exists(tmpfilename))
            {
                MessageBox.Show("Faceuid does not exist for: " + filename);
                return "ERROR: faceuid did not already exist";
            }

            string popdir = System.IO.Directory.GetCurrentDirectory();
            string folder = Path.GetDirectoryName(filename);

            try
            {
                System.IO.Directory.SetCurrentDirectory(folder);

                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(tmpfilename);
                    faceuid = sr.ReadToEnd();
                    sr.Close();
                }
                catch
                {
                    retval = "ERROR: cannot find faceuid";

                    // so... try to fix it.  upload the image to generate the faceuid
                    upload(filename);

                    // try again
                    try
                    {
                        if (System.IO.File.Exists(tmpfilename))
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(tmpfilename);
                            faceuid = sr.ReadToEnd();
                            sr.Close();
                            if (faceuid != "")
                            {
                                retval = "";
                            }
                        }
                    }
                    finally
                    {

                    }
                }

                if (retval == "")
                {
                    //2157ab2d-1db7-11e3-b11e-80ee734cfa77
                    parms[0] = "http://betafaceapi.com/service.svc/";     // service end point
                    parms[1] = "d45fd466-51e2-4701-8da8-04351c872236";    // service user id
                    parms[2] = "171e8465-f548-401d-b63b-caf0dc28df5f";    // service user password
                    parms[3] = "recognize";                               // command to execute
                    parms[4] = faceuid;// "2157ab2d-1db7-11e3-b11e-80ee734cfa77";    // faceuid;    // the uid of the face to check
                    parms[6] = "targets";

                    List<string> fuids = GET_my_faceuids(filename);
                    int x = 7;

                    foreach (string s in fuids)
                    {
                        if (x < 27)
                        {
                            parms[x] = s;
                            x++;
                        }
                    }

                    doit(parms);  // recognize
                }
                else
                {
                    retval = "ERROR: no result";
                }
            }
            finally
            {
                System.IO.Directory.SetCurrentDirectory(popdir);
            }

            string[] data = logstring.Split('\n');

            int perfectmatches = 0;
            Double bestscore = 0;
            Double tempscore = 0;

            for (int x = 0; x < data.Count(); x++)
            {
                string s = data[x];
                if (s.Contains("score: "))
                {
                    s = s.Remove(0, 7);
                    tempscore = Convert.ToDouble(s);

                    if (tempscore == 1) { perfectmatches++; }
                    else
                    {
                        if (tempscore > bestscore) { bestscore = tempscore; }
                    }
                }
            }

            if (retval == "")
            {
                if (bestscore > 0) { retval = bestscore.ToString("#.####"); }
                else if (perfectmatches > 0) { retval = "1"; }
            }


            return retval;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            clearlog(); //.Text = "";
            Application.DoEvents();
            upload(tb_selectedfile.Text);
            tb_response.Text = this.logstring;
        }

        // recognize a faceuid
        private void btn_Go_Click(object sender, EventArgs e)
        {
            clearlog(); //.Text = "";
            Application.DoEvents();
            recognize(tb_selectedfile.Text);
            tb_response.Text = this.logstring;
        }



        // BetafaceWebServiceTest.exe "http://betafaceapi.com/service.svc/" "d45fd466-51e2-4701-8da8-04351c872236" "171e8465-f548-401d-b63b-caf0dc28df5f" upload sample1.jpg sample2.jpg sample3.jpg
        private void btn_factorytest_Click(object sender, EventArgs e)
        {
            string[] parms;

            clearlog();//.Text = "";

            parms = new string[15];

            //MessageBox.Show("Hard coded path");

            if (!System.IO.Directory.Exists(@"c:\vs2013\betaface"))
            {
                MessageBox.Show("This Sytsem is not equipped with factory demo");
                return;
            }

            System.IO.Directory.SetCurrentDirectory(@"c:\vs2013\betaface");

            parms[0] = "http://betafaceapi.com/service.svc/";  // service end point
            parms[1] = "d45fd466-51e2-4701-8da8-04351c872236"; // service user id
            parms[2] = "171e8465-f548-401d-b63b-caf0dc28df5f"; // service user password
            parms[3] = "upload";                               // command to execute
            parms[4] = "sample1.jpg";                          // files[] to upload
            parms[5] = "sample2.jpg";
            parms[6] = "sample3.jpg";

            doit(parms);  // upload

            /*BetafaceWebServiceTest.exe "http://betafaceapi.com/service.svc/" "d45fd466-51e2-4701-8da8-04351c872236" "171e8465-f548-401d-b63b-caf0dc28df5f" 
             *        recognize "1d27d600-9d3f-102e-b521-e15710483b50" targets 
             *        "1cdd7bf3-9d3f-102e-b521-e15710483b50" 
             *        "1d27d600-9d3f-102e-b521-e15710483b50" 
             *        "1db1d01e-9d3f-102e-b521-e15710483b50" 
             *        "15114d46-9d3f-102e-b521-e15710483b50" 
             *        "15ab6f86-9d3f-102e-b521-e15710483b50"
            pause
            @echo comparing second face on image Sample1.jpg with persons in celebrities public namespace 
            BetafaceWebServiceTest.exe "http://betafaceapi.com/service.svc/" "d45fd466-51e2-4701-8da8-04351c872236" "171e8465-f548-401d-b63b-caf0dc28df5f" 
             *        recognize "1d27d600-9d3f-102e-b521-e15710483b50" targets "all@celebrities.betaface.com"*/


            parms[0] = "http://betafaceapi.com/service.svc/";  // service end point
            parms[1] = "d45fd466-51e2-4701-8da8-04351c872236"; // service user id
            parms[2] = "171e8465-f548-401d-b63b-caf0dc28df5f"; // service user password
            parms[3] = "recognize";                               // command to execute
            parms[4] = "1d27d600-9d3f-102e-b521-e15710483b50";    // not sure, some guid...
            parms[6] = "targets";
            parms[7] = "1cdd7bf3-9d3f-102e-b521-e15710483b50";
            parms[8] = "1d27d600-9d3f-102e-b521-e15710483b50";
            parms[9] = "1db1d01e-9d3f-102e-b521-e15710483b50";
            parms[10] = "15114d46-9d3f-102e-b521-e15710483b50";
            parms[11] = "15ab6f86-9d3f-102e-b521-e15710483b50";

            doit(parms);  // recognize


            parms[0] = "http://betafaceapi.com/service.svc/";  // service end point
            parms[1] = "d45fd466-51e2-4701-8da8-04351c872236"; // service user id
            parms[2] = "171e8465-f548-401d-b63b-caf0dc28df5f"; // service user password
            parms[3] = "recognize";                               // command to execute
            parms[4] = "1d27d600-9d3f-102e-b521-e15710483b50";    // not sure, some guid...
            parms[6] = "targets";
            parms[7] = "all@celebrities.betaface.com";            // compare to who

            doit(parms);  // recognize

            tb_response.Text = this.logstring;
        }





        private void btn_FolderTest_Click(object sender, EventArgs e)
        {
            string filename = tb_selectedfile.Text;
            if (filename == "")
            {
                return;
            }

            List<string> jj = GET_my_faceuid_filenames(filename);

            List<string> faceuids = new List<string>();

            clearlog();
            log("Faceuid Files for the path of: " + Path.GetDirectoryName(filename));

            foreach (string s in jj)
            {
                log(s + "\r\n");
            }

            faceuids = GET_my_faceuids(filename);

            log(" ");
            log("Faceuids found:");
            log(" ");

            foreach (string s in faceuids)
            {
                log(s); // tb_response.AppendText(s + "\r\n");
            }

            tb_response.Text = this.logstring;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string basedir = tb_googledrive.Text;

            StreamWriter sw = new StreamWriter(basedir + @"\testfile.written");
            sw.WriteLine("Hello World");
            sw.Close();

            StreamReader sr = new StreamReader(basedir + @"\testfile.written");
            string s = sr.ReadToEnd();
            sr.Close();

            sw = new StreamWriter(basedir + @"\testfile.read");
            sw.WriteLine(s);
            sw.Close();

            tb_response.Text = this.logstring; 
            MessageBox.Show("Done");
        }


    }


    /*URL: http://www.betafaceapi.com/service.svc/UploadNewImage_File
    Method: POST

    Headers:

    Content-Length: 94998
    Content-Type: application/xml
    Cache-Control: no-cache(optional)
    Pragma: no-cache(optional)

    Message Body:

    <?xml version="1.0" encoding="utf-8"?>
    <ImageRequestBinary xmlns:xsd="http://www.w3.org/2001/XMLSchema" 
                           xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
    <api_key>d45fd466-51e2-4701-8da8-04351c872236</api_key>
    <api_secret>171e8465-f548-401d-b63b-caf0dc28df5f</api_secret>
    <detection_flags></detection_flags>
    <imagefile_data>/9j/4AAQS..here goes Base64binary encoded image file..grVZWUk6f/2Q==</imagefile_data>
    <original_filename>sample1.jpg</original_filename>
    </ImageRequestBinary>

    You should get back response like this:

    <BetafaceImageResponse xmlns:i="http://www.w3.org/2001/XMLSchema-instance">
    <int_response>0</int_response>
    <string_response>ok</string_response>
    <img_uid>ec43984f-0e81-4a85-866f-31f605d1f3be</img_uid>
    </BetafaceImageResponse>*/


}
