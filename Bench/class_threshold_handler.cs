using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bench
{
    class class_threshold_handler
    {
        public riskcard device1_card { get; set; }
        public riskcard device2_card { get; set; }
        public riskcard device3_card { get; set; }

        public riskcard userrole_card { get; set; }
        public riskcard location_card { get; set; } // user location slash environment
        public riskcard target_card { get; set; }

        public riskcard password_card { get; set; } // authentication mechanisms have risk cards
        public riskcard attvoice_card { get; set; }
        public riskcard attface_card { get; set; }
        public riskcard betaface_card { get; set; }
        public riskcard knowledge_card { get; set; }
        public riskcard sms_card { get; set; }

        public int passworddevice { get; set; }
        public int attvoicedevice { get; set; }
        public int attfacedevice { get; set; }
        public int betafacedevice { get; set; }
        public int knowledgedevice { get; set; }
        public int smsdevice { get; set; }

        public class_highlowsession user_summary { get; set; }

        public Double thresh_minpw = Double.NaN;
        public Double thresh_minattvoice = Double.NaN;
        public Double thresh_minattface = Double.NaN;
        public Double thresh_minbetaface = Double.NaN;
        public Double thresh_minknowledge = Double.NaN;
        public Double thresh_minsms = Double.NaN;

        public class_threshold_handler()
        {
            // initialize
        }

        public void calculate()
        {
            // calculate the thresholds per authentication mechanism
        }

        public int batch_drive_one_auth_test(string authmech, string parmCharacter)
        {
            int retval = 0;

            IEnumerable<class_rawauthsession> sessions = class_gather_sessionstats.GET_IEnumerable_User_Character(user_summary.user, parmCharacter);

            class_rmm_handler rmm = new class_rmm_handler();
            // set up rmm handler properties

            foreach (class_rawauthsession session in sessions)
            {
                if (authmech == "password")
                {
                    retval += rmm.call_one_authentication_mechanism(user_summary.user, session.startdatetime, authmech, session.password_score);
                }
                if (authmech == "attvoice")
                {
                    retval += rmm.call_one_authentication_mechanism(user_summary.user, session.startdatetime, authmech, session.attvoice_score1);
                }
                if (authmech == "attface")
                {
                    retval += rmm.call_one_authentication_mechanism(user_summary.user, session.startdatetime, authmech, session.attface_score1);
                }
                if (authmech == "betaface")
                {
                    retval += rmm.call_one_authentication_mechanism(user_summary.user, session.startdatetime, authmech, session.betaface_score1);
                }
                if (authmech == "knowledge")
                {
                    retval += rmm.call_one_authentication_mechanism(user_summary.user, session.startdatetime, authmech, session.knowledge_score);
                }
                if (authmech == "sms")
                {
                    retval += rmm.call_one_authentication_mechanism(user_summary.user, session.startdatetime, authmech, session.sms_score);
                }
            }
            
            return retval;
        }
    }
}
