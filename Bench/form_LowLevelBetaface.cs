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
        public form_LowLevelBetaface()
        {
            InitializeComponent();
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

        static void PrintUsage()
        {
            Console.WriteLine("Usage: BetafaceWebServiceTest <webservce url> <username> <password>");
            Console.WriteLine("                              upload <filepath or url 1> [filepath or url 2] [filepath or url 3]...");
            Console.WriteLine("                              recognize <face GUID> targets recognize <face GUID or personname@namespace or all@namespace> [face GUID or personname@namespace or all@namespace] ...");
        }

        static void doMain(string[] args)
        {
            if (args.Length < 5)
            {
                PrintUsage();
                return;
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // connect to webservice
            
            Console.WriteLine("Connecting to webservice...");

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

                Console.WriteLine("Uploading images...");

                Dictionary<Guid, string> images = new Dictionary<Guid, string>();

                for (int i = iArgIdx; i < args.Length; i++)
                {
                    if (!String.IsNullOrEmpty(args[i]))
                    {
                        if (args[i].Substring(0, 5) == "http:")
                        {
                            Console.WriteLine("test transfer via url");

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
                                    Console.WriteLine("transfer ok");
                                }
                                else
                                {
                                    Console.WriteLine("error " + ret.int_response + " " + ret.string_response);
                                };
                            }
                        }
                        else if (File.Exists(args[i]))
                        {
                            byte[] data = ReadFile(args[i]);
                            if (null != data)
                            {
                                Console.WriteLine("transfer file " + args[i]);

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
                                        images.Add(new Guid(ret.img_uid), args[i]);
                                        Console.WriteLine("transfer ok");
                                    }
                                    else
                                    {
                                        Console.WriteLine("error " + ret.int_response + " " + ret.string_response);
                                    };
                                }
                            };
                        }
                        else
                        {
                            Console.WriteLine("File not found " + args[i]);
                        };
                    };
                };

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // retrieve results

                Console.WriteLine("Waiting for results...");
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
                                Console.WriteLine("error " + ret.int_response + " " + ret.string_response);
                                images.Remove(images.ElementAt(i).Key);
                                break;
                            }
                            else if (ret.int_response == 0)
                            {
                                string strResI = images.ElementAt(i).Key.ToString() + ".xml";
                                Console.WriteLine("writing result to " + strResI);
                                using (StreamWriter sw = new StreamWriter(strResI))
                                {
                                    sw.WriteLine(str);
                                }

                                if (null == ret.faces.FaceInfo)
                                {
                                    Console.WriteLine(images.ElementAt(i).Value + " - no faces found");
                                }
                                else
                                {
                                    Console.WriteLine(images.ElementAt(i).Value + " - " + ret.faces.FaceInfo.Length + " faces found");
                                    for (int j = 0; j < ret.faces.FaceInfo.Length; j++)
                                    {
                                        Console.WriteLine("face " + j + " score:" + ret.faces.FaceInfo[j].score + " x:" + ret.faces.FaceInfo[j].x + " y:" + ret.faces.FaceInfo[j].y + " w:" + ret.faces.FaceInfo[j].width + " h:" + ret.faces.FaceInfo[j].height + " a:" + ret.faces.FaceInfo[j].angle);

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
                                                    Console.WriteLine("writing face image to " + strResF + ".jpg");
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
                    Console.WriteLine("no faces guids");
                    return;
                }
                System.Collections.ArrayList al_targets = new System.Collections.ArrayList();
                for (iArgIdx++; iArgIdx < args.Length; iArgIdx++)
                {
                    Guid g;
                    if (!String.IsNullOrEmpty(args[iArgIdx]))
                    {
                        al_targets.Add(args[iArgIdx]);
                    }
                }
                if (al_targets.Count == 0)
                {
                    Console.WriteLine("no face ids, persons or namespaces");
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
                        Console.WriteLine("recognize request sent, uid:" + recognize_request_id.ToString());
                    }
                    else
                    {
                        Console.WriteLine("error sending recognize request " + ret.int_response + "\n" + ret.string_response);
                    };
                }

                //wait for result
                if (recognize_request_id != Guid.Empty)
                {
                    Console.WriteLine("waiting for recognize result");

                    while (true)
                    {
                        RecognizeResultRequest compareResultRequest = new RecognizeResultRequest();
                        compareResultRequest.api_key = Username;
                        compareResultRequest.api_secret = Password;
                        compareResultRequest.recognize_uid = recognize_request_id.ToString();

                        HttpContent compareResultRequest_body = HttpContentExtensions.CreateXmlSerializable(compareResultRequest);
                        System.Net.ServicePointManager.Expect100Continue = false;

                        using (HttpResponseMessage response = client.Post("GetRecognizeResult", compareResultRequest_body))
                        {
                            // Throws an exception if not OK 
                            response.EnsureStatusIsSuccessful();

                            response.Content.LoadIntoBuffer();
                            string str = response.Content.ReadAsString();

                            BetafaceRecognizeResponse ret = response.Content.ReadAsXmlSerializable<BetafaceRecognizeResponse>();
                            if (ret.int_response < 0)
                            {
                                Console.WriteLine("error " + ret.int_response + " " + ret.string_response);
                                break;
                            }
                            else if (ret.int_response == 0)
                            {
                                string strRes = "recognize_" + recognize_request_id.ToString() + ".txt";
                                Console.WriteLine("writing result to " + strRes);
                                using (StreamWriter sw = new StreamWriter(strRes))
                                {
                                    sw.WriteLine("Request");
                                    foreach (string g in recognizeRequest.faces_uids)
                                    {
                                        sw.WriteLine(g);
                                    };
                                    sw.WriteLine();
                                    sw.WriteLine("Response");

                                    foreach (BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfo mi in ret.faces_matches.FaceRecognizeInfo)
                                    {
                                        sw.WriteLine("recognizing " + mi.face_uid);
                                        sw.WriteLine("closest matches");
                                        foreach (BetafaceRecognizeResponseFaces_matchesFaceRecognizeInfoMatchesPersonMatchInfo pmi in mi.matches.PersonMatchInfo)
                                        {
                                            sw.WriteLine(pmi.person_name + " " + pmi.confidence + " " + pmi.is_match + " " + pmi.face_uid);
                                        }
                                    }
                                }

                                Console.WriteLine(str);
                                break;
                            };
                        };
                        Thread.Sleep(500);
                    };
                }
            }
            else
            {
                Console.WriteLine("Unrecognized command");

                PrintUsage();
            }

            return;
        }
    }


}
