using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvenSecure_DARPA_CFT_2013
{
    public partial class formCVSSUser3 : Form
    {

        private riskcard card = null;

        private Boolean dirty = false;

        private Boolean formisloading = false;

        private string basedir = "";
        private string filenameopened = "";

        public formCVSSUser3()
        {
            InitializeComponent();
            if (card == null)
            {
                card = new riskcard();
            }

            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            basedir = System.IO.Path.GetDirectoryName(a.Location);
        }

        public formCVSSUser3(riskcard parmcard)
        {
            InitializeComponent();
            card = parmcard;
            if (card == null)
            {
                clear();
                card = new riskcard();
            }

            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            basedir = System.IO.Path.GetDirectoryName(a.Location);
        }

        public formCVSSUser3(riskcard parmcard, Boolean enabledebug)
        {
            InitializeComponent();
            card = parmcard;
            if (card == null)
            {
                clear();
                card = new riskcard();
            }
            if (enabledebug == true)
            {
                ll_testformcalculations.Visible = true;
                ll_testformcalculations.Enabled = true;
            }

            System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
            basedir = System.IO.Path.GetDirectoryName(a.Location);
        }

        private void clear()
        {
            this.tb_Output.Text = "";

            this.combo_AccessVector.SelectedIndex = 0;
            this.combo_AccessComplexity.SelectedIndex = 0;
            this.combo_Authentication.SelectedIndex = 0;
            this.combo_availimpact.SelectedIndex = 0;
            this.combo_collateraldamagepotential.SelectedIndex = 0;
            this.combo_confidentialityrequirement.SelectedIndex = 0;
            this.combo_confimpact.SelectedIndex = 0;
            this.combo_exploitability.SelectedIndex = 0;
            this.combo_integimpact.SelectedIndex = 0;
            this.combo_integrityrequirement.SelectedIndex = 0;
            this.combo_remediationlevel.SelectedIndex = 0;
            this.combo_reportconfidence.SelectedIndex = 0;
            this.combo_systemavailabilityrequirement.SelectedIndex = 0;
            this.combo_targetdistribution.SelectedIndex = 0;

            this.combo_CATEGORY.SelectedIndex = 0;


            dirty = false;
        }

        private void formcalc()
        {
            if (card == null)
            {
                card = new riskcard();
            }

            card.iAuthentication = this.combo_Authentication.SelectedIndex;
            card.iAccessComplexity = this.combo_AccessComplexity.SelectedIndex;
            card.iAccessVector = this.combo_AccessVector.SelectedIndex;
            card.iAvailabilityRequirement = this.combo_systemavailabilityrequirement.SelectedIndex;
            card.iAvailImpact = this.combo_availimpact.SelectedIndex;
            card.iCollateralDamagePotential = this.combo_collateraldamagepotential.SelectedIndex;
            card.iConfidentialityRequirement = this.combo_confidentialityrequirement.SelectedIndex;
            card.iConfImpact = this.combo_confimpact.SelectedIndex;
            card.iExploitability = this.combo_exploitability.SelectedIndex;
            card.iIntegImpact = this.combo_integimpact.SelectedIndex;
            card.iIntegrityRequirement = this.combo_integrityrequirement.SelectedIndex;
            card.iRemediationLevel = this.combo_remediationlevel.SelectedIndex;
            card.iReportConfidence = this.combo_reportconfidence.SelectedIndex;
            card.iTargetDistribution = this.combo_targetdistribution.SelectedIndex;

            card.sName = this.tb_Scorecardname.Text;
            card.sDescription = this.tb_Description.Text;
            card.sCategory = this.combo_CATEGORY.Text;

            string ts = "";
            string output = "";

            ts = card.basescore().ToString();
            output = "Base Score: " + ts + "\r\n";

            ts = card.temporalequation().ToString();

            output = output +  "Temporal Score: " + ts + "\r\n";
  
            ts = card.environmentalequation().ToString();
            output = output + "Environmental Equation: " + ts;

            this.tb_Output.Text = output;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }


        private void setformtocard()
        {
            if (card != null)
            {
                this.tb_Output.Text = "";

                this.combo_AccessVector.SelectedIndex = card.iAccessVector;
                this.combo_AccessComplexity.SelectedIndex = card.iAccessComplexity;
                this.combo_Authentication.SelectedIndex = card.iAuthentication;
                this.combo_availimpact.SelectedIndex = card.iAvailImpact;
                this.combo_collateraldamagepotential.SelectedIndex = card.iCollateralDamagePotential;
                this.combo_confidentialityrequirement.SelectedIndex = card.iConfImpact;
                this.combo_confimpact.SelectedIndex = card.iConfidentialityRequirement;
                this.combo_exploitability.SelectedIndex = card.iExploitability;
                this.combo_integimpact.SelectedIndex = card.iIntegImpact;
                this.combo_integrityrequirement.SelectedIndex = card.iIntegrityRequirement;
                this.combo_remediationlevel.SelectedIndex = card.iRemediationLevel;
                this.combo_reportconfidence.SelectedIndex = card.iReportConfidence;
                this.combo_systemavailabilityrequirement.SelectedIndex = card.iAvailabilityRequirement;
                this.combo_targetdistribution.SelectedIndex = card.iTargetDistribution;

                this.tb_Scorecardname.Text = card.sName;
                this.tb_Description.Text = card.sDescription;

                int x = 0;
                combo_CATEGORY.Text = "ERROR ON LOAD";

                for (x = 0; x < combo_CATEGORY.Items.Count; x++)
                {
                    string s = combo_CATEGORY.Items[x].ToString();
                    if (s == card.sCategory)
                    {
                        combo_CATEGORY.SelectedIndex = x;
                        combo_CATEGORY.Text = s;
                    }
                }

            }

            this.formisloading = false;
            this.formcalc();
        }


        private void formCVSSUser3_Shown(object sender, EventArgs e)
        {
            this.setformtocard();
        }

        private void combo_AccessVector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.formisloading)
            {
                dirty = true;

                this.formcalc();
            }
        }

        /*  reference example 1
                ----------------------------------------------------
                BASE METRIC                 EVALUATION         SCORE
                ----------------------------------------------------
                Access Vector               [Network]         (1.00)
                Access Complexity           [Low]             (0.71)
                Authentication              [None]            (0.704) <- does not match their calc, should be 0
                Confidentiality Impact      [None]            (0.00)
                Integrity Impact            [None]            (0.00)
                Availability Impact         [Complete]        (0.66)
                ----------------------------------------------------
                BASE FORMULA                              BASE SCORE
                ----------------------------------------------------
                Impact = 10.41*(1-(1)*(1)*(0.34)) == 6.9
                Exploitability = 20*0.71*0.704*1 == 10.0
                f(Impact) = 1.176
                BaseScore = (0.6*6.9 + 0.4*10.0  1.5)*1.176
                                                            == (7.8)
                ----------------------------------------------------

                ----------------------------------------------------
                TEMPORAL METRIC             EVALUATION         SCORE
                ----------------------------------------------------
                Exploitability              [Functional]      (0.95)
                Remediation Level           [Official-Fix]    (0.87)
                Report Confidence           [Confirmed]       (1.00)
                ----------------------------------------------------
                TEMPORAL FORMULA                      TEMPORAL SCORE
                ----------------------------------------------------
                round(7.8 * 0.95 * 0.87 * 1.00)             == (6.4)
                ----------------------------------------------------

                ----------------------------------------------------
                ENVIRONMENTAL METRIC        EVALUATION         SCORE
                ----------------------------------------------------
                Collateral Damage Potential [None - High]  {0 - 0.5}
                Target Distribution         [None - High]  {0 - 1.0}
                Confidentiality Req.        [Medium]           (1.0)
                Integrity Req.              [Medium]           (1.0)
                Availability Req.           [High]             (1.51)
                ----------------------------------------------------
                ENVIRONMENTAL FORMULA            ENVIRONMENTAL SCORE
                ----------------------------------------------------
                AdjustedImpact = min(10,10.41*(1-(1-0*1)*(1-0*1)
                         *(1-0.66*1.51))                   == (10.0)
                AdjustedBase =((0.6*10)+(0.4*10.0)1.5)*1.176
                                                           == (10.0)
                AdjustedTemporal == (10*0.95*0.87*1.0)      == (8.3)
                EnvScore = round((8.3+(10-8.3)*{0-0.5})*{0-1})
                                                     == (0.00 - 9.2)
                ----------------------------------------------------
         * 
         * 
         * reference example 2
         *   ----------------------------------------------------
        BASE METRIC                 EVALUATION         SCORE
        ----------------------------------------------------
        Access Vector               [Network]         (1.00)
        Access Complexity           [Low]             (0.71)
        Authentication              [None]            (0.704)
        Confidentiality Impact      [Complete]        (0.66)
        Integrity Impact            [Complete]        (0.66)
        Availability Impact         [Complete]        (0.66)
        ----------------------------------------------------
        FORMULA                                   BASE SCORE
        ----------------------------------------------------
        Impact = 10.41*(1-(0.34*0.34*0.34)) == 10.0
        Exploitability = 20*0.71*0.704*1 == 10.0
        f(Impact) = 1.176
        BaseScore =((0.6*10.0)+(0.4*10.0)1.5)*1.176
                                                   == (10.0)
        ----------------------------------------------------

        ----------------------------------------------------
        TEMPORAL METRIC             EVALUATION         SCORE
        ----------------------------------------------------
        Exploitability              [Functional]      (0.95)
        Remediation Level           [Official-Fix]    (0.87)
        Report Confidence           [Confirmed]       (1.00)
        ----------------------------------------------------
        FORMULA                               TEMPORAL SCORE
        ----------------------------------------------------
        round(10.0 * 0.95 * 0.87 * 1.00) ==            (8.3)
        ----------------------------------------------------

        ----------------------------------------------------
        ENVIRONMENTAL METRIC        EVALUATION         SCORE
        ----------------------------------------------------
        Collateral Damage Potential [None - High]  {0 - 0.5}
        Target Distribution         [None - High]  {0 - 1.0}
        Confidentiality Req.        [Medium]           (1.0)
        Integrity Req.              [Medium]           (1.0)
        Availability Req.           [Low]              (0.5)
        ----------------------------------------------------
        FORMULA                          ENVIRONMENTAL SCORE
        ----------------------------------------------------
        AdjustedImpact = 10.41*(1-(1-0.66*1)*(1-0.66*1)
                 *(1-0.66*0.5)) == 9.6
        AdjustedBase =((0.6*9.6)+(0.4*10.0)1.5)*1.176
                                                    == (9.7)
        AdjustedTemporal == (9.7*0.95*0.87*1.0)     == (8.0)
        EnvScore = round((8.0+(10-8.0)*{0-0.5})*{0-1})
                         ==                     (0.00 - 9.0)
        ----------------------------------------------------
         * 
         * 
         * reference example 3
         * ----------------------------------------------------
        BASE METRIC                 EVALUATION         SCORE
        ----------------------------------------------------
        Access Vector               [Local]           (0.395)
        Access Complexity           [High]            (0.35)
        Authentication              [None]            (0.704)
        Confidentiality Impact      [Complete]        (0.66)
        Integrity Impact            [Complete]        (0.66)
        Availability Impact         [Complete]        (0.66)
        ----------------------------------------------------
        FORMULA                                   BASE SCORE
        ----------------------------------------------------
        Impact = 10.41*(1-(0.34*0.34*0.34)) == 10.0
        Exploitability = 20*0.35*0.704*0.395 == 1.9
        f(Impact) = 1.176
        BaseScore =((0.6*10)+(0.4*1.9)1.5)*1.176
                                                  ==   (6.2)
        ----------------------------------------------------

        ----------------------------------------------------
        TEMPORAL METRIC             EVALUATION         SCORE
        ----------------------------------------------------
        Exploitability              [Proof-Of-Concept](0.90)
        Remediation Level           [Official-Fix]    (0.87)
        Report Confidence           [Confirmed]       (1.00)
        ----------------------------------------------------
        FORMULA                               TEMPORAL SCORE
        ----------------------------------------------------
        round(6.2 * 0.90 * 0.87 * 1.00) ==             (4.9)
        ----------------------------------------------------

        ----------------------------------------------------
        ENVIRONMENTAL METRIC        EVALUATION         SCORE
        ----------------------------------------------------
        Collateral Damage Potential [None - High]  {0 - 0.5}
        Target Distribution         [None - High]  {0 - 1.0}
        Confidentiality Req.        [Medium]           (1.0)
        Integrity Req.              [Medium]           (1.0)
        Availability Req.           [Medium]           (1.0)
        ----------------------------------------------------
        FORMULA                          ENVIRONMENTAL SCORE
        ----------------------------------------------------
        AdjustedTemporal == 4.9
        EnvScore = round((4.9+(10-4.9)*{0-0.5})*{0-1})
                                            ==  (0.00 - 7.5)
        ----------------------------------------------------
         */

        private string expect(double b, double e, double t)
        {
            string header = "";
            string retval = "";

            header += "Expecting base=" + b.ToString() + " environmental=" + e.ToString() + " temporal=" + t.ToString() + "\r\n";

            this.formcalc();
            if (card.basescore() != b)
            {
                retval = retval + "BaseScore Expected: " + b.ToString() + " but calculated: " + card.basescore().ToString() + "\r\n";
            }

            if (card.environmentalequation() != e)
            {
                retval = retval + "Environmental Score Expected: " + e.ToString() + " but calculated: " + card.environmentalequation().ToString() + "\r\n";
            }

            if (card.temporalequation() != t)
            {
                retval = retval + "TemporalScore Expected: " + t.ToString() + " but calculated: " + card.temporalequation().ToString() + "\r\n";
            }

            if (retval.Length == 0)
            {
                retval = header + "Ok..." + "\r\n";
            }

            return retval;
        }

        // Use http://nvd.nist.gov/cvss.cfm?calculator&version=2 to generate use-cases
        // test this form vs. that form in a variety of exemplary use-cases to make sure the 
        // calculations are working properly
        // SEE: http://www.first.org/cvss/cvss-guide.html
        // ---------------------------------------------------------------------------------------------
        private void ll_testformcalculations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string report = "";

            // case 0
            this.clear();
            this.formcalc();
            report = report + "Case 0: Defaults should yield zeroes\r\n" + expect(0.0, 0.0, 0.0) + "\r\n";

            // case 1
            this.clear();
            this.combo_AccessVector.SelectedIndex = 3; // 1.00
            this.combo_AccessComplexity.SelectedIndex = 3; // 0.71
            this.combo_Authentication.SelectedIndex = 1; // 0.704 
            this.combo_confimpact.SelectedIndex = 0; // 0.0
            this.combo_integimpact.SelectedIndex = 0; // 0.0
            this.combo_availimpact.SelectedIndex = 2; // 0.66
        /*  reference example 1
                BASE FORMULA                               BASE SCORE
                -----------------------------------------------------
                Impact = 10.41*(1-(1)*(1)*(0.34)) == 6.9
                Exploitability = 20*0.71*0.704*1 == 10.0
                f(Impact) = 1.176
                BaseScore = (0.6*6.9 + 0.4*10.0  1.5)*1.176  == (7.8)
                -----------------------------------------------------
         */
            this.combo_exploitability.SelectedIndex = 2; // 0.95
            this.combo_remediationlevel.SelectedIndex = 0; // 0.87
            this.combo_reportconfidence.SelectedIndex = 2;  // 1.00

         /*
                TEMPORAL METRIC             EVALUATION         SCORE
                ----------------------------------------------------
                round(7.8 * 0.95 * 0.87 * 1.00)             == (6.4)
                ----------------------------------------------------
        */

            this.combo_collateraldamagepotential.SelectedIndex = 0; // try 0 lowest 0.5 highest in this test case(s)
            this.combo_targetdistribution.SelectedIndex = 0;  // try 0 to 1.0 lowest to highest in this test cases
            this.combo_confidentialityrequirement.SelectedIndex = 1; // 1.0  medium
            this.combo_integrityrequirement.SelectedIndex = 1; // medium 1.0

            this.combo_systemavailabilityrequirement.SelectedIndex = 2; // 1.51 high
        /*
                ----------------------------------------------------
                ENVIRONMENTAL FORMULA            ENVIRONMENTAL SCORE
                ----------------------------------------------------
                AdjustedImpact = min(10,10.41*(1-(1-0*1)*(1-0*1)
                         *(1-0.66*1.51))                   == (10.0)
                AdjustedBase =((0.6*10)+(0.4*10.0)1.5)*1.176
                                                           == (10.0)
                AdjustedTemporal == (10*0.95*0.87*1.0)      == (8.3)
                EnvScore = round((8.3+(10-8.3)*{0-0.5})*{0-1})
                                                     == (0.00 - 9.2)  <-- 0.00  so far
                ----------------------------------------------------
         */
            this.formcalc();
            report = report + "Case 1.1: Collateral Damage Potential 0, Target Distribution 0\r\n" + expect(7.8, 0.0, 6.4) + "\r\n";
            //report += card.basedebug;

            this.combo_collateraldamagepotential.SelectedIndex = 4; // try 0 lowest 0.5 highest in this test case(s)
            this.combo_targetdistribution.SelectedIndex = 3;  // try 0 to 1.0 lowest to highest in this test cases
         /*
            == (0.00 - 9.2)  <-- 9.2 now
            ----------------------------------------------------
         */
            this.formcalc();
            report = report + "Case 1.2: Collateral Damage Potential 0.5, Target Distribution 1\r\n" + expect(7.8, 9.2, 6.4) + "\r\n";
            //report += card.basedebug;
            report += card.environdebug;

            MessageBox.Show("Testing Report:\r\n\r\n" + report);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Delete", "Delete?", MessageBoxButtons.YesNo);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.clear();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((filenameopened.Length != 0) && (card != null) )
            {
                this.formcalc();
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.SupportMultiDottedExtensions = true;
                saveFileDialog1.Filter = "RiskCard|.riskcard";
                saveFileDialog1.DefaultExt = ".riskcard";
                saveFileDialog1.FileName = filenameopened; // <-- check
                saveFileDialog1.InitialDirectory = basedir;
                saveFileDialog1.ShowDialog();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formcalc();
            if ((card != null)&&(card.sCategory.Trim()!="")&&(card.sName.Trim()!=""))
            {
                string filename = "";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.SupportMultiDottedExtensions = true;
                saveFileDialog1.Filter = "RiskCard|.riskcard";
                saveFileDialog1.DefaultExt = ".riskcard";

                saveFileDialog1.FileName = card.safestring_FILENAME(card.sCategory) + "." + card.safestring_FILENAME(card.sName);
                saveFileDialog1.InitialDirectory = basedir;
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    filename = saveFileDialog1.FileName;
                    card.SaveToFile(filename);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.formcalc();
            openFileDialog1.FileName = card.safestring_FILENAME(combo_CATEGORY.Text) + ".*.riskcard";
            openFileDialog1.InitialDirectory = basedir;
            openFileDialog1.AddExtension = true;
            openFileDialog1.SupportMultiDottedExtensions = true;
            openFileDialog1.Filter = "RiskCard|*.riskcard";
            openFileDialog1.DefaultExt = "*.riskcard";
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.formisloading = true;
                    card.LoadFromFile(openFileDialog1.FileName);
                    setformtocard();
                }
                finally
                {
                    this.formisloading = false;
                }
            }

            //openFileDialog1.ShowDialog();
        }

        private void formCVSSUser3_Load(object sender, EventArgs e)
        {

        }


    }
}
