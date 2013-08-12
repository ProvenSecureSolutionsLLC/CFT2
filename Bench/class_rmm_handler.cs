using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bench
{
    class class_rmm_handler
    {
        public string one_factor_auth_script_template_filename { get; set; }
        public string three_sample_auth_1_script_template_filename { get; set; }
        public string three_sample_auth_2_script_template_filename { get; set; }
        public string three_sample_auth_3_script_template_filename { get; set; }

        public class_rmm_handler()
        {
            // Initialize
        }

        public int call_one_authentication_mechanism(string parmUser, DateTime sessionstart, string authmech, Double score)
        {
            int retval = 0;

            return retval;
        }

        public int call_three_sample_auth(string parmUser, DateTime sessionstart, string authmech, int samplenumber, Double score)
        {
            int retval = 0;

            return retval;
        }
    }
}
