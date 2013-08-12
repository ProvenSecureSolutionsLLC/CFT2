using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bench
{
    // Model of: NIST CVSS Common Vulnerability Scoring System
    // http://nvd.nist.gov/cvss.cfm?calculator&version=2

    public class riskcard
    {
        private string _category = "";
        private string _name = "";
        private string _description = "";

        private double _accesscomplexity = 0.35;
        private double _authentication = 0.45;
        private double _accessvector = 0.395;
        private double _confimpact = 0.00;
        private double _integimpact = 0.00;
        private double _availimpact = 0.00;
        private double _exploitability = 0.85;
        private double _reportconfidence = 0.87;
        private double _remediationlevel = 0.90;
        private double _collateraldamagepotential = 0.00;
        private double _targetdistribution = 0.00;
        private double _confreq = 0.50;
        private double _integreq = 0.50;
        private double _availreq = 0.50;


        public string basedebug = "";
        public string environdebug = "";

        public riskcard()
        {

        }




/*
BaseScore = round_to_1_decimal(((0.6*Impact)+(0.4*Exploitability)-1.5)*f(Impact))
Impact = 10.41*(1-(1-ConfImpact)*(1-IntegImpact)*(1-AvailImpact))
Exploitability = 20* AccessVector*AccessComplexity*Authentication

f(impact)= 0 if Impact=0, 1.176 otherwise
AccessVector     = case AccessVector of    requires local access: 0.395   adjacent network accessible: 0.646  network accessible: 1.0
AccessComplexity = case AccessComplexity of   high: 0.35  medium: 0.61   low: 0.71
Authentication   = case Authentication of   requires multiple instances of authentication: 0.45  requires single instance of authentication: 0.56   requires no authentication: 0.704
ConfImpact       = case ConfidentialityImpact of   none:             0.0     partial:          0.275           complete:         0.660
IntegImpact      = case IntegrityImpact of     none:             0.0     partial:          0.275          complete:         0.660
AvailImpact      = case AvailabilityImpact of    none:             0.0     partial:          0.275         complete:         0.660
*/
        public double basescore() 
        {
            double retval = 0.00;
            double impact = 0.00;
            double exploitability = 0.00;
            double fimpact = 0.00;

            basedebug = "basescore debug: \r\n";
            basedebug += "_confimpact = " + _confimpact.ToString() + "\r\n";
            basedebug += "_integimpact = " + _integimpact.ToString() + "\r\n";
            basedebug += "_availimpact = " + _availimpact.ToString() + "\r\n";
            basedebug += "_accesscomplexity = " + _accesscomplexity.ToString() + "\r\n";
            basedebug += "_authentication = " + _authentication.ToString() + "\r\n";
            basedebug += "_accessvector = " + _accessvector.ToString() + "\r\n";

            impact = 10.41*(1-(1-_confimpact)*(1-_integimpact)*(1-_availimpact));
            exploitability = 20 * this._accesscomplexity * _authentication * _accessvector;

            if (impact == 0.00) 
            { 
                fimpact = 0.00;
            }
            else
            {
                fimpact = 1.176;
            }

            basedebug += "impact, exploitability, fimpact: " + impact.ToString() + ", " + exploitability.ToString() + ", " + fimpact.ToString() + "\r\n\r\n";

            retval = System.Math.Round(( (0.6 * impact) + (0.4 * exploitability) - 1.5) * fimpact, 1);

          return retval;
        }

/*
TemporalScore = round_to_1_decimal(BaseScore*Exploitability*RemediationLevel*ReportConfidence)

Exploitability   = case Exploitability of      unproven:             0.85      proof-of-concept:     0.9   functional:           0.95      high:                 1.00       not defined:          1.00
RemediationLevel = case RemediationLevel of   official-fix:         0.87   temporary-fix:        0.90   workaround:           0.95   unavailable:          1.00    not defined:          1.00
ReportConfidence = case ReportConfidence of   unconfirmed:          0.90  uncorroborated:       0.95     confirmed:            1.00   not defined:          1.00
*/
        public double temporalequation()
        {
            double retval = 0.00;

            retval = System.Math.Round(basescore() * _exploitability * _remediationlevel * _reportconfidence, 1);

            return retval;
       }

/*
EnvironmentalScore = round_to_1_decimal((AdjustedTemporal+(10-AdjustedTemporal)*CollateralDamagePotential)*TargetDistribution)

  AdjustedTemporal = TemporalScore recomputed with the BaseScores Impact sub-equation replaced with the AdjustedImpact equation
  AdjustedImpact = min(10,10.41*(1-(1-ConfImpact*ConfReq)*(1-IntegImpact*IntegReq)*(1-AvailImpact*AvailReq)))

  CollateralDamagePotential = case CollateralDamagePotential of  none:            0    low:             0.1   low-medium:      0.3  medium-high:     0.4     high:            0.5                         not defined:     0
  TargetDistribution        = case TargetDistribution of    none:            0   low:             0.25     medium:          0.75  high:            1.00    not defined:     1.00
        ConfReq 	         = case ConfReq of          low:              0.5       medium:           1.0   high:             1.51      not defined:      1.0
        IntegReq         = case IntegReq of      low:              0.5     medium:           1.0     high:             1.51     not defined:      1.0
        AvailReq         = case AvailReq of     low:              0.5      medium:           1.0      high:             1.51      not defined:      1.0
*/
               public double environmentalequation()
               {
                   double retval = 0.00;
                   double adjustedtemporal = 0.00;
                   double adjustedimpact = 0.00;
                   double fimpact = 0.00;
                   double newbase = 0.00; 
                   // double newtemporal = 0.00;


                   environdebug = "environmental score debug: \r\n";
                   environdebug += "_confimpact = " + _confimpact.ToString() + "\r\n";
                   environdebug += "_integimpact = " + _integimpact.ToString() + "\r\n";
                   environdebug += "_availimpact = " + _availimpact.ToString() + "\r\n";
                   environdebug += "_confreq = " + _confreq.ToString() + "\r\n";
                   environdebug += "_integreq = " + _integreq.ToString() + "\r\n";
                   environdebug += "_availreq = " + _availreq.ToString() + "\r\n";
                   environdebug += "_accesscomplexity = " + _accesscomplexity.ToString() + "\r\n";
                   environdebug += "_authentication = " + _authentication.ToString() + "\r\n";
                   environdebug += "_accessvector = " + _accessvector.ToString() + "\r\n";
                   environdebug += "_exploitability = " + _exploitability.ToString() + "\r\n";
                   environdebug += "_remediationlevel = " + _remediationlevel.ToString() + "\r\n";
                   environdebug += "_reportconfidence = " + _reportconfidence.ToString() + "\r\n";


                   adjustedimpact = System.Math.Min(10, ( 10.41*(1-(1-_confimpact * _confreq) * (1-_integimpact * _integreq) * (1-_availimpact * _availreq))));

                   if (adjustedimpact == 0.00)
                   {
                       fimpact = 0.00;
                   }
                   else
                   {
                       fimpact = 1.176;
                   }

                   environdebug += "adjustedimpact = " + adjustedimpact.ToString() + "\r\n";

//                   newbase = ( (0.6 * adjustedimpact) + (0.4 * _exploitability) - 1.5) * fimpact;
                   newbase = System.Math.Round(((0.6 * adjustedimpact) + (0.4 * adjustedimpact) - 1.5) * fimpact, 1);

                   environdebug += "newbase = " + newbase.ToString() + "\r\n";

                   adjustedtemporal = System.Math.Round(newbase * _exploitability * _remediationlevel * _reportconfidence, 1);

                   environdebug += "adjustedtemporal = " + adjustedtemporal.ToString() + "\r\n";

                   retval = System.Math.Round((adjustedtemporal + (10 - adjustedtemporal) * _collateraldamagepotential) * _targetdistribution, 1);

                   environdebug += "final environmental = " + retval.ToString() + "\r\n\r\n";

                   return retval;
               }




               public string sCategory
               {
                   get
                   {
                       return _category;
                   }
                   set
                   {
                       _category = value;
                   }
               }

               public string sName
               {
                   get
                   {
                       return _name;
                   }
                   set
                   {
                       _name = value;
                   }
               }

               public string sDescription
               {
                   get
                   {
                       return _description;
                   }
                   set
                   {
                       _description = value;
                   }
               }


                // the i(something) properties are ListBox Item Number

                // iAccessComplexity
                // -1.00 = Undefined = Item 0
                // 0.35 = high = Item 1
                // 0.61 = medium = Item 2
                // 0.71 = low = item 3
                public int iAccessComplexity  
                {
                    get 
                    {
                        int retval = 0;
                        if (_accesscomplexity == -1.00) { retval = 0; }
                        if (_accesscomplexity == 0.35) { retval = 1; }
                        if (_accesscomplexity == 0.61) { retval = 2; }
                        if (_accesscomplexity == 0.71) { retval = 3; }
                        return retval;
                    }
                    set 
                    {
                        if (value == 0) { _accesscomplexity = -1.00; }
                        if (value == 1) { _accesscomplexity = 0.35; }
                        if (value == 2) { _accesscomplexity = 0.61; }
                        if (value == 3) { _accesscomplexity = 0.71; }
                    }
                }

                // iAuthentication
                // 0 undefined:   -1.00
                // 1 Requires no authentication:                                                     0.704
                // 2 Requires single instance of authentication:                              0.56
                // 3 Requires multiple instances of authentication:                         0.45
                public int iAuthentication
                {
                    get
                    {
                        int retval = 0;
                        if (_authentication == -1.00) { retval = 0; }
                        if (_authentication == 0.704) { retval = 1; }
                        if (_authentication == 0.56) { retval = 2; }
                        if (_authentication == 0.45) { retval = 3; }
                        return retval;
                    }
                    set
                    {
                        if (value == 0) { _authentication = -1.00; }
                        if (value == 1) { _authentication = 0.704; }
                        if (value == 2) { _authentication = 0.56; }
                        if (value == 3) { _authentication = 0.45; }
                    }
                }

                /*
                 undefined:                                             -1.00
                 Requires Local Access:                            0.395
                 Local Network Accessible:                         0.646
                 Network Accessible:                                1.00
                */
        public int iAccessVector
        {
            get
            {
                int retval = 0;
                if (_accessvector == -1.00) { retval = 0; }
                if (_accessvector == 0.395) { retval = 1; }
                if (_accessvector == 0.646) { retval = 2; }
                if (_accessvector == 1.00) { retval = 3; }
                return retval;
            }
            set
            {
                if (value == 0) { _accessvector = -1.00; }
                if (value == 1) { _accessvector = 0.395; }
                if (value == 2) { _accessvector = 0.646; }
                if (value == 3) { _accessvector = 1.00; }
            }
        }

        /*
         * none:                                                 0
           partial:                                               0.275
           complete:                                           0.660
         */
        public int iConfImpact
        {
            get
            {
                int retval = 0;
                if (_confimpact == 0.00) { retval = 0; }
                if (_confimpact == 0.275) { retval = 1; }
                if (_confimpact == 0.660) { retval = 2; }
                return retval;
            }
            set
            {
                if (value == 0) { _confimpact = 0.00; }
                if (value == 1) { _confimpact = 0.275; }
                if (value == 2) { _confimpact = 0.660; }
            }
        }

        /*
         * none:                                                 0
           partial:                                               0.275
           complete:                                           0.660
         */
        public int iIntegImpact
        {
            get
            {
                int retval = 0;
                if (_integimpact == 0.00) { retval = 0; }
                if (_integimpact == 0.275) { retval = 1; }
                if (_integimpact == 0.660) { retval = 2; }
                return retval;
            }
            set
            {
                if (value == 0) { _integimpact = 0.00; }
                if (value == 1) { _integimpact = 0.275; }
                if (value == 2) { _integimpact = 0.660; }
            }
        }

        /*
         * none:                                                 0
           partial:                                               0.275
           complete:                                           0.660
         */
        public int iAvailImpact
        {
            get
            {
                int retval = 0;
                if (_availimpact == 0.00) { retval = 0; }
                if (_availimpact == 0.275) { retval = 1; }
                if (_availimpact == 0.660) { retval = 2; }
                return retval;
            }
            set
            {
                if (value == 0) { _availimpact = 0.00; }
                if (value == 1) { _availimpact = 0.275; }
                if (value == 2) { _availimpact = 0.660; }
            }
        }

        /*
         * Collateral Damage Potential
         * none:                                  0
           low:                                     0.1
           low-medium:                        0.3
           medium-high:                        0.4
           high:                                     0.5
           not defined:                            0
         */
        public int iCollateralDamagePotential
        {
            get
            {
                int retval = 0;
                if (_collateraldamagepotential == 0.00) { retval = 0; }
                if (_collateraldamagepotential == 0.10) { retval = 1; }
                if (_collateraldamagepotential == 0.30) { retval = 2; }
                if (_collateraldamagepotential == 0.40) { retval = 3; }
                if (_collateraldamagepotential == 0.50) { retval = 4; }
                return retval;
            }
            set
            {
                if (value == 0) { _collateraldamagepotential = 0.00; }
                if (value == 1) { _collateraldamagepotential = 0.10; }
                if (value == 2) { _collateraldamagepotential = 0.30; }
                if (value == 3) { _collateraldamagepotential = 0.40; }
                if (value == 4) { _collateraldamagepotential = 0.50; }
            }
        }

        /* TargetDistribution
         * none:                                               0
           low:                                                 0.25
           medium:                                          0.75
           high:                                                1.00
           not defined:                                    1.00
         */
        public int iTargetDistribution
        {
            get
            {
                int retval = 0;
                if (_targetdistribution == 0.00) { retval = 0; }
                if (_targetdistribution == 0.25) { retval = 1; }
                if (_targetdistribution == 0.75) { retval = 2; }
                if (_targetdistribution == 1.00) { retval = 3; }
                return retval;
            }
            set
            {
                if (value == 0) { _targetdistribution = 0.00; }
                if (value == 1) { _targetdistribution = 0.25; }
                if (value == 2) { _targetdistribution = 0.75; }
                if (value == 3) { _targetdistribution = 1.00; }
            }
        }

        /* ConfidentialityRequirement
         * Low:                                            0.5
           Medium:                                       1.00
           High:                                             1.51
           Not defined:                                 1.00
         */
        public int iConfidentialityRequirement
        {
            get
            {
                int retval = 0;
                if (_confreq == 0.50) { retval = 0; }
                if (_confreq == 1.00) { retval = 1; }
                if (_confreq == 1.51) { retval = 2; }
                return retval;
            }
            set
            {
                if (value == 0) { _confreq = 0.50; }
                if (value == 1) { _confreq = 1.00; }
                if (value == 2) { _confreq = 1.51; }
            }
        }

        /* IntegrityRequirement
         * Low:                                            0.5
           Medium:                                       1.00
           High:                                             1.51
           Not defined:                                 1.00
         */
        public int iIntegrityRequirement
        {
            get
            {
                int retval = 0;
                if (_integreq == 0.50) { retval = 0; }
                if (_integreq == 1.00) { retval = 1; }
                if (_integreq == 1.51) { retval = 2; }
                return retval;
            }
            set
            {
                if (value == 0) { _integreq = 0.50; }
                if (value == 1) { _integreq = 1.00; }
                if (value == 2) { _integreq = 1.51; }
            }
        }


        /* AvailabilityRequirement
         * Low:                                            0.5
           Medium:                                       1.00
           High:                                             1.51
           Not defined:                                 1.00
         */
        public int iAvailabilityRequirement
        {
            get
            {
                int retval = 0;
                if (_availreq == 0.50) { retval = 0; }
                if (_availreq == 1.00) { retval = 1; }
                if (_availreq == 1.51) { retval = 2; }
                return retval;
            }
            set
            {
                if (value == 0) { _availreq = 0.50; }
                if (value == 1) { _availreq = 1.00; }
                if (value == 2) { _availreq = 1.51; }
            }
        }

        /* Exploitability
         * unproven:                                          0.85
           proof-of-concept:                                0.9
           functional:                                          0.95
           high:                                                   1.00
           not defined:                                       1.00
         */
        public int iExploitability
        {
            get
            {
                int retval = 0;
                if (_exploitability == 0.85) { retval = 0; }
                if (_exploitability == 0.90) { retval = 1; }
                if (_exploitability == 0.95) { retval = 2; }
                if (_exploitability == 1.00) { retval = 3; }
                return retval;
            }
            set
            {
                if (value == 0) { _exploitability = 0.85; }
                if (value == 1) { _exploitability = 0.90; }
                if (value == 2) { _exploitability = 0.95; }
                if (value == 3) { _exploitability = 1.00; }
            }
        }

        /* RemediationLevel
         * official-fix:                                0.87
           temporary-fix:                          0.90
           workaround:                             0.95
           unavailable:                              1.00
           not defined:                              1.00
         */
        public int iRemediationLevel
        {
            get
            {
                int retval = 0;
                if (this._remediationlevel == 0.87) { retval = 0; }
                if (_remediationlevel == 0.90) { retval = 1; }
                if (_remediationlevel == 0.95) { retval = 2; }
                if (_remediationlevel == 1.00) { retval = 3; }
                return retval;
            }
            set
            {
                if (value == 0) { _remediationlevel = 0.87; }
                if (value == 1) { _remediationlevel = 0.90; }
                if (value == 2) { _remediationlevel = 0.95; }
                if (value == 3) { _remediationlevel = 1.00; }
            }
        }

        /*
         * unconfirmed:                             0.90
           uncorroborated:                        0.95      
           unconfirmed:                             1.00
           not defined:                               1.00
         */
        public int iReportConfidence
        {
            get
            {
                int retval = 0;
                if (_reportconfidence == 0.90) { retval = 0; }
                if (_reportconfidence == 0.95) { retval = 1; }
                if (_reportconfidence == 1.00) { retval = 2; }
                return retval;
            }
            set
            {
                if (value == 0) { _reportconfidence = 0.90; }
                if (value == 1) { _reportconfidence = 0.95; }
                if (value == 2) { _reportconfidence = 1.00; }
            }
        }


        public string safestring_FILENAME(string parms)
        {
            string ts = "";

            ts = parms.Trim();
            ts = ts.Replace(' ', '_');
            ts = ts.Replace('|', '_');
            ts = ts.Replace('/', '_');
            ts = ts.Replace('\\', '_');
            ts = ts.Replace('`', '_');
            ts = ts.Replace('~', '_');
            ts = ts.Replace('!', '_');
            ts = ts.Replace('@', '_');
            ts = ts.Replace('#', '_');
            ts = ts.Replace('$', '_');
            ts = ts.Replace('%', '_');
            ts = ts.Replace('^', '_');
            ts = ts.Replace('&', '_');
            ts = ts.Replace('*', '_');
            ts = ts.Replace('(', '_');
            ts = ts.Replace(')', '_');
            ts = ts.Replace('+', '_');
            ts = ts.Replace('[', '_');
            ts = ts.Replace(']', '_');
            ts = ts.Replace('{', '_');
            ts = ts.Replace('}', '_');
            ts = ts.Replace(':', '_');
            ts = ts.Replace(';', '_');
            ts = ts.Replace('\"', '_');
            ts = ts.Replace('\'', '_');
            ts = ts.Replace('?', '_');
            ts = ts.Replace('<', '_');
            ts = ts.Replace('>', '_');
            ts = ts.Replace(',', '_');
            ts = ts.Replace('.', '_');

            return ts;
        }

        public string safestring_DATA(string parms)
        {
            string ts = "";

            ts = parms.Trim();
            //ts = ts.Replace(' ', '_');
            ts = ts.Replace('|', '_');
            //ts = ts.Replace('/', '_');
            //ts = ts.Replace('\\', '_');
            //ts = ts.Replace('`', '_');
            //ts = ts.Replace('~', '_');
            //ts = ts.Replace('!', '_');
            //ts = ts.Replace('@', '_');
            //ts = ts.Replace('#', '_');
            //ts = ts.Replace('$', '_');
            //ts = ts.Replace('%', '_');
            //ts = ts.Replace('^', '_');
            //ts = ts.Replace('&', '_');
            //ts = ts.Replace('*', '_');
            //ts = ts.Replace('(', '_');
            //ts = ts.Replace(')', '_');
            //ts = ts.Replace('+', '_');
            //ts = ts.Replace('[', '_');
            //ts = ts.Replace(']', '_');
            //ts = ts.Replace('{', '_');
            //ts = ts.Replace('}', '_');
            //ts = ts.Replace(':', '_');
            //ts = ts.Replace(';', '_');
            //ts = ts.Replace('\"', '_');
            //ts = ts.Replace('\'', '_');
            //ts = ts.Replace('?', '_');
            //ts = ts.Replace('<', '_');
            //ts = ts.Replace('>', '_');
            //ts = ts.Replace(',', '_');
            //ts = ts.Replace('.', '_');

            return ts;
        }

        public string addrecfield(string parms)
        {
            string retval = "";
            retval = safestring_DATA(parms) + '|';

            return retval;
        }

        public string buildstringrec()
        {
            string retval = "";

            retval += addrecfield(_category);
            retval += addrecfield(_name);
            retval += addrecfield(this._description);
            retval += addrecfield(this._accesscomplexity.ToString());
            retval += addrecfield(this._accessvector.ToString());
            retval += addrecfield(this._authentication.ToString());
            retval += addrecfield(this._availimpact.ToString());
            retval += addrecfield(this._availreq.ToString());
            retval += addrecfield(this._collateraldamagepotential.ToString());
            retval += addrecfield(this._confimpact.ToString());
            retval += addrecfield(this._confreq.ToString());
            retval += addrecfield(this._exploitability.ToString());
            retval += addrecfield(this._integimpact.ToString());
            retval += addrecfield(this._integreq.ToString());
            retval += addrecfield(this._remediationlevel.ToString());
            retval += addrecfield(this._reportconfidence.ToString());
            retval += addrecfield(this._targetdistribution.ToString());

            return retval;
        }

        public void SaveToFile(string filename)
        {
            string writeme = buildstringrec();

            System.IO.StreamWriter sw = new System.IO.StreamWriter(filename);
            sw.Write(writeme);
            sw.Close();
            
        }

        public void LoadFromFile(string filename)
        {
            string buffer = "";

            System.IO.StreamReader sr = new System.IO.StreamReader(filename);
            buffer = sr.ReadToEnd();
            sr.Close();


            string [] ray = buffer.Split(new Char [] {'|'});

            /*
            string sdebug = "";

            int x = 0;

            for (x = 0; x < ray.Count(); x++)
            {
                sdebug += x.ToString() + " " + ray[x] + "\r\n";
            }

            System.IO.StreamWriter sw = new System.IO.StreamWriter(filename+".debug");
            sw.Write(sdebug);
            sw.Close();
0 AUTHENTICATION FACTORS
1 This is the third < test of > you know. the thing
2 How about in here is less < than that which is greater than > this other thing ~!@#$%^&*()_+=_}{[\][\]:":';';<>?<><?.,/.,/.,
3 -1
4 0.395
5 -1
6 0
7 0.5
8 0
9 0
10 0.5
11 0.85
12 0
13 0.5
14 0.87
15 0.9
16 0
17 
* 
             */

            this.sCategory = ray[0];
            this.sName = ray[1];
            this.sDescription = ray[2];
            this._accesscomplexity = Convert.ToDouble(ray[3]);
            this._accessvector = Convert.ToDouble(ray[4]);
            this._authentication = Convert.ToDouble(ray[5]);
            this._availimpact = Convert.ToDouble(ray[6]);
            this._availreq = Convert.ToDouble(ray[7]);
            this._collateraldamagepotential = Convert.ToDouble(ray[8]);
            this._confimpact = Convert.ToDouble(ray[9]);
            this._confreq = Convert.ToDouble(ray[10]);
            this._exploitability = Convert.ToDouble(ray[11]);
            this._integimpact = Convert.ToDouble(ray[12]);
            this._integreq = Convert.ToDouble(ray[13]);
            this._remediationlevel = Convert.ToDouble(ray[14]);
            this._reportconfidence = Convert.ToDouble(ray[15]);
            this._targetdistribution = Convert.ToDouble(ray[16]);

        }


    }
}
