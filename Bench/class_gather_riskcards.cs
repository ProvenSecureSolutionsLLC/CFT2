using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bench
{
    class class_gather_riskcards
    {

        private static string basedir = "";
        private static string rdir = "";

        private static void recalc()
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            basedir = System.IO.Path.GetDirectoryName(a.Location);

            rdir = basedir + "\\RData";

            bool isExists = System.IO.Directory.Exists(rdir);

            try
            {
                if (!isExists)
                    System.IO.Directory.CreateDirectory(rdir);
            }
            catch
            {
             //   MessageBox.Show("Unable to create folder: " + rdir, "Process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // RiskCards started life as individual text files
        // We use linq to bring them into queryable list forms
        // ---------------------------------------------------
            public static List<riskcard> doit()
            {
                recalc();

                string startFolder = basedir; // @"C:\vs2013\Projects\ProvenSecure_DARPA_CFT_2013\ProvenSecure_DARPA_CFT_2013\bin\Debug";

                // Take a snapshot of the file system.
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(startFolder);

                // This method assumes that the application has discovery permissions 
                // for all folders under the specified path.
                IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.TopDirectoryOnly);

                //Create the query
                IEnumerable<System.IO.FileInfo> fileQuery =
                    from file in fileList
                    where file.Extension == ".riskcard"
                    orderby file.Name
                    select file;

                List<riskcard> retval = new List<riskcard>();

                foreach (System.IO.FileInfo fi in fileQuery)
                {
                    riskcard jj = new riskcard();
                    jj.LoadFromFile(fi.FullName);
                    retval.Add(jj);
                }

                return retval;
            }


        // Make IEnumerable<riskcard>
            public static IEnumerable<riskcard> GET_IEnumerable_AllRiskCards()
            {
                recalc(); 

                string startFolder = basedir; // @"C:\vs2013\Projects\ProvenSecure_DARPA_CFT_2013\ProvenSecure_DARPA_CFT_2013\bin\Debug";

                // Take a snapshot of the file system.
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(startFolder);

                // This method assumes that the application has discovery permissions 
                // for all folders under the specified path.
                IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.TopDirectoryOnly);

                //Create the query
                IEnumerable<System.IO.FileInfo> fileQuery =
                    from file in fileList
                    where file.Extension == ".riskcard"
                    orderby file.Name
                    select file;

                List<riskcard> allriskcards = new List<riskcard>();

                //Execute the query. This might write out a lot of files! 
                foreach (System.IO.FileInfo fi in fileQuery)
                {
                    riskcard jj = new riskcard();
                    jj.LoadFromFile(fi.FullName);
                    allriskcards.Add(jj);
                }

                IEnumerable<riskcard> retval =
                    from card in allriskcards
                    //where card.sCategory != ""
                    orderby card.sCategory, card.sName
                    select card;

                return retval;
            }

            public static IEnumerable<riskcard> GET_IEnumerable_DEVICE_1()
            {
                IEnumerable<riskcard> retval =
                    from card in GET_IEnumerable_AllRiskCards()
                    where card.sCategory == "DEVICE_1"
                    orderby card.sName
                    select card;
                return retval;
            }
            public static IEnumerable<riskcard> GET_IEnumerable_DEVICE_2()
            {
                IEnumerable<riskcard> retval =
                    from card in GET_IEnumerable_AllRiskCards()
                    where card.sCategory == "DEVICE_2"
                    orderby card.sName
                    select card;
                return retval;
            }
            public static IEnumerable<riskcard> GET_IEnumerable_DEVICE_3()
            {
                IEnumerable<riskcard> retval =
                    from card in GET_IEnumerable_AllRiskCards()
                    where card.sCategory == "DEVICE_3"
                    orderby card.sName
                    select card;
                return retval;
            }
            public static IEnumerable<riskcard> GET_IEnumerable_LOCATIONS()
            {
                IEnumerable<riskcard> retval =
                    from card in GET_IEnumerable_AllRiskCards()
                    where card.sCategory == "LOCATIONS"
                    orderby card.sName
                    select card;
                return retval;
            }
            public static IEnumerable<riskcard> GET_IEnumerable_ROLES()
            {
                IEnumerable<riskcard> retval =
                    from card in GET_IEnumerable_AllRiskCards()
                    where card.sCategory == "ROLES"
                    orderby card.sName
                    select card;
                return retval;
            }

            // For now, this sets the risk across all authenticators
            // All compromised ?  ALL risk free ?  ALL medium vulnerable, etc.,
            public static IEnumerable<riskcard> GET_IEnumerable_AUTH_MECHANISM()
            {
                IEnumerable<riskcard> retval =
                    from card in GET_IEnumerable_AllRiskCards()
                    where card.sCategory.StartsWith("AUTH_MECHANISM")
                    orderby card.sName
                    select card;
                return retval;
            }
            public static IEnumerable<riskcard> GET_IEnumerable_TARGETS()
            {
                IEnumerable<riskcard> retval =
                    from card in GET_IEnumerable_AllRiskCards()
                    where card.sCategory == "TARGETS"
                    orderby card.sName
                    select card;
                return retval;
            }

    }
}
