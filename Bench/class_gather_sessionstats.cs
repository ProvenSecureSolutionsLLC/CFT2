using System;
using System.Collections.Generic;
using System.Linq;
using LinqLib.Array;
using LinqLib.Sequence;
using System.Text;
using System.Threading.Tasks;

namespace Bench
{
    class class_gather_sessionstats
    {
        
       

        // We use linq to bring them into queryable list forms
        // ---------------------------------------------------
        public static List<class_rawauthsession> GET_List_AllSessions()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            string basedir = System.IO.Path.GetDirectoryName(a.Location);

            string startFolder = basedir + "\\UserData";

            // Take a snapshot of the file system.
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(startFolder);

            // This method assumes that the application has discovery permissions 
            // for all folders under the specified path.
            IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            //Create the query
            IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.Extension == ".session"
                orderby file.Name
                select file;

            List<class_rawauthsession> retval = new List<class_rawauthsession>();

            foreach (System.IO.FileInfo fi in fileQuery)
            {
                class_rawauthsession jj = new class_rawauthsession();
                jj.LoadFromFile(fi.FullName);
                retval.Add(jj);
            }

            return retval;
        }


        // Make IEnumerable<riskcard>
        public static IEnumerable<class_rawauthsession> GET_IEnumerable_AllSessions()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            string basedir = System.IO.Path.GetDirectoryName(a.Location);

            string startFolder = basedir + "\\UserData";

            // Take a snapshot of the file system.
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(startFolder);

            // This method assumes that the application has discovery permissions 
            // for all folders under the specified path.
            IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            //Create the query
            IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.Extension == ".session"
                orderby file.Name
                select file;

            List<class_rawauthsession> allsessions = new List<class_rawauthsession>();

            //Execute the query. This might write out a lot of files! 
            foreach (System.IO.FileInfo fi in fileQuery)
            {
                class_rawauthsession jj = new class_rawauthsession();
                jj.LoadFromFile(fi.FullName);
                allsessions.Add(jj);
            }

            IEnumerable<class_rawauthsession> retval =
                from session in allsessions
                //where card.sCategory != ""
                orderby session.user, session.startdatetime
                select session;

            return retval;
        }

        public static IEnumerable<class_rawauthsession> GET_IEnumerable_User(string parmUser)
        {
            IEnumerable<class_rawauthsession> retval =
                from session in GET_IEnumerable_AllSessions()
                where session.user == parmUser
                orderby session.user, session.startdatetime 
                select session;
            return retval;
        }

        public static IEnumerable<class_rawauthsession> GET_IEnumerable_User_Character(string parmUser, string parmCharacter)
        {
            IEnumerable<class_rawauthsession> retval =
                from session in GET_IEnumerable_AllSessions()
                where session.user == parmUser
                where session.character == parmCharacter
                orderby session.user, session.startdatetime
                select session;
            return retval;
        }

        public static class_highlowsession GETHighLowMeanStdDev_User(string parmUser)
        {
            class_highlowsession hls = new class_highlowsession(parmUser, "All");

            IEnumerable<class_rawauthsession> usersessions = GET_IEnumerable_User(parmUser);

            foreach(class_rawauthsession session in usersessions) {
                hls.addPWScore(session.password_score);

                hls.addATTVoiceScore(session.attvoice_score1);
                //hls.addATTVoiceScore(session.attvoice_score2);
                //hls.addATTVoiceScore(session.attvoice_score3);

                hls.addATTFaceScore(session.attface_score1);
                //hls.addATTFaceScore(session.attface_score2);
                //hls.addATTFaceScore(session.attface_score3);

                hls.addBetafaceScore(session.betaface_score1);
                //hls.addBetafaceScore(session.betaface_score2);
                //hls.addBetafaceScore(session.betaface_score3);

                hls.addKnowledgeScore(session.knowledge_score);

                hls.addSMSScore(session.sms_score);
            }

            return hls;
        }

        // You can say
        // "Get me all sessions for Bob, just the totally 'Random' generated ones if any"
        // "Get me all sessions for Bob, that are 'Blank', if any
        // Bob, 'Actual' authentication results, if any
        // Bob, 'RangeGen' - generated based on Actual range, if any
        public static class_highlowsession GETHighLowMeanStdDev_User_Character(string parmUser, string parmCharacter)
        {
            class_highlowsession hls = new class_highlowsession(parmUser, parmCharacter);

            IEnumerable<class_rawauthsession> usersessions = GET_IEnumerable_User_Character(parmUser, parmCharacter);

            foreach (class_rawauthsession session in usersessions)
            {
                hls.addPWScore(session.password_score);

                hls.addATTVoiceScore(session.attvoice_score1);
                hls.addATTVoiceScore(session.attvoice_score2);
                hls.addATTVoiceScore(session.attvoice_score3);

                hls.addATTFaceScore(session.attface_score1);
                hls.addATTFaceScore(session.attface_score2);
                hls.addATTFaceScore(session.attface_score3);

                hls.addBetafaceScore(session.betaface_score1);
                hls.addBetafaceScore(session.betaface_score2);
                hls.addBetafaceScore(session.betaface_score3);

                hls.addKnowledgeScore(session.knowledge_score);

                hls.addSMSScore(session.sms_score);
            }

            return hls;
        }
    }
}
