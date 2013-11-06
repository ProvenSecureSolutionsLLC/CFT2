using System;
using System.Collections.Generic;
using System.Linq;
using LinqLib.Operators;
using System.Text;
using System.Threading.Tasks;

namespace Bench
{
    public class class_highlowsession
    {
        // use the data gathered in to here to generate more authentication session results for each user
        public string user { get; set; }
        public string character { get; set; }

        public DateTime startdatetime_earliest { get; set; }
        public DateTime enddatetime_latest { get; set; }

        public Double min(List<Double> list)
        {
            Double retval = Double.MaxValue;
            foreach (Double d in list)
            {
                if (d < retval)
                {
                    retval = d;
                }
            }
            return retval;
        }
        public Double max(List<Double> list)
        {
            Double retval = Double.MinValue;
            foreach (Double d in list)
            {
                if (d > retval)
                {
                    retval = d;
                }
            }
            return retval;
        }

        public Double sum(List<Double> list) // make it generically reusable 
        {
            Double retval = 0.00;
            foreach (Double d in list)
            {
                if (double.IsNaN(d))
                {
                    // do nothing
                } else 
                if (d != 0.00)
                {
                    retval += d;
                }
            }
            return retval;
        }

        public Double mean(List<Double> list)
        {
            Double retval = 0.00;
            retval = sum(list) / list.Count;
            return retval;
        }

        public Double stddev(List<Double> list)  // make it generically reusable, recompute the mean
        {
            Double retval = 0.00;
            Double tempmean = 0.00;
            Double sqrsum = 0.00;
            Double sqravg = 0.00;
            Double temp = 0.00;
            int count = 0;

            // figure out the mean
            tempmean = mean(list);

            foreach (Double d in list)
            {
                temp = Math.Pow((d - tempmean), 2);
                sqrsum += temp;
                count++;
            }

            sqravg = sqrsum / count;
            retval = Math.Sqrt(sqravg);

            return retval;
        }

        private List<Double> _pwscores = new List<Double>();
        public Double _pwmin
        {
            get
            {
                return min(_pwscores);
            }
            ////set; 
        }
        public Double _pwmax
        {
            get
            {
                return max(_pwscores);
            }
            ////set; 
        }
        public Double _pwsum
        {
            get
            {
                return sum(_pwscores);
            }
            ////set;
        }
        public Double _pwmean
        {
            get
            {
                return mean(_pwscores);
            }
            ////set;
        }
        public Double _pwstddev
        {
            get
            {
                return stddev(_pwscores);
            }
            ////set; 
        }
        public int _pwcount
        {
            get { return _pwscores.Count; }
            //set;
        }

        private List<Double> _attvoicescores = new List<Double>();
        public Double _attvoicemin
        {
            get
            {
                return min(_attvoicescores);
            }
            //set; 
        }
        public Double _attvoicemax
        {
            get
            {
                return max(_attvoicescores);
            }
            //set; 
        }
        public Double _attvoicesum
        {
            get
            {
                return sum(_attvoicescores);
            }
            //set;
        }
        public Double _attvoicemean
        {
            get
            {
                return mean(_attvoicescores);
            }
            //set;
        }
        public Double _attvoicestddev
        {
            get
            {
                return stddev(_attvoicescores);
            }
            //set; 
        }
        public int _attvoicecount
        {
            get { return _attvoicescores.Count; }
            //set;
        }

        private List<Double> _attfacescores = new List<Double>();
        public Double _attfacemin
        {
            get
            {
                return min(_attfacescores);
            }
            //set; 
        }
        public Double _attfacemax
        {
            get
            {
                return max(_attfacescores);
            }
            //set; 
        }
        public Double _attfacemean
        {
            get
            {
                return mean(_attfacescores);
            }
        }
        public Double _attfacestddev
        {
            get
            {
                return stddev(_attfacescores);
            }
            //set; 
        }
        public Double _attfacesum
        {
            get
            {
                return sum(_attfacescores);
            }
            //set; 
        }
        public int _attfacecount
        {
            get { return _attfacescores.Count; }
            //set; 
        }


        private List<Double> _betafacescores = new List<Double>();
        public Double _betafacemin
        {
            get
            {
                return min(_betafacescores);
            }
            //set;
        }
        public Double _betafacemax
        {
            get
            {
                return max(_betafacescores);
            }
            //set;
        }
        public Double _betafacemean
        {
            get
            {
                return mean(_betafacescores);
            }
        }
        public Double _betafacestddev
        {
            get
            {
                return stddev(_betafacescores);
            }
            //set;
        }
        public Double _betafacesum
        {
            get
            {
                return sum(_betafacescores);
            }
            //set;
        }
        public int _betafacecount
        {
            get { return _betafacescores.Count; }
            //set;
        }


        private List<Double> _knowledgescores = new List<Double>();
        public Double _knowledgemin
        {
            get
            {
                return min(_knowledgescores);
            }
            //set;
        }
        public Double _knowledgemax
        {
            get
            {
                return max(_knowledgescores);
            }
            //set;
        }
        public Double _knowledgemean
        {
            get
            {
                return mean(_knowledgescores);
            }
        }
        public Double _knowledgestddev
        {
            get
            {
                return stddev(_knowledgescores);
            }
            //set;
        }
        public Double _knowledgesum
        {
            get
            {
                return sum(_knowledgescores);
            }
            //set;
        }
        public int _knowledgecount
        {
            get { return _knowledgescores.Count; }
            //set;
        }

        private List<Double> _smsscores = new List<Double>();
        public Double _smsmin
        {
            get
            {
                return min(_smsscores);
            }
            //set;
        }
        public Double _smsmax
        {
            get
            {
                return max(_smsscores);
            }
            //set;
        }
        public Double _smsmean
        {
            get
            {
                return mean(_smsscores);
            }
        }
        public Double _smsstddev
        {
            get
            {
                return stddev(_smsscores);
            }
            //set;
        }
        public Double _smssum
        {
            get
            {
                return sum(_smsscores);
            }
            //set;
        }
        public int _smscount
        {
            get { return _smsscores.Count; }
            //set;
        }

        public void init()
        {
            user = "Default";
            character = "Blank";
        }

        public class_highlowsession(string parmUser, string parmCharacter)
        {
            init();
            user = parmUser;
            character = parmCharacter;
        }

        public void addPWScore(Double parmScore)
        {
            // Let's just collect a list of doubles
            if (double.IsNaN(parmScore)) { } else
            if (parmScore != 0.00)
            {
                _pwscores.Add(parmScore);
            }
        }

        public void addATTVoiceScore(Double parmScore)
        {
            if (double.IsNaN(parmScore)) { }
            else
                if (parmScore != 0.00)
                {
                    _attvoicescores.Add(parmScore);
                }
        }

        public void addATTFaceScore(Double parmScore)
        {
            if (double.IsNaN(parmScore)) { }
            else
                if (parmScore != 0.00)
                {
                    _attfacescores.Add(parmScore);
                }
        }

        public void addBetafaceScore(Double parmScore)
        {
            if (double.IsNaN(parmScore)) { }
            else
                if (parmScore != 0.00)
                {
                    _betafacescores.Add(parmScore);
                }
        }

        public void addKnowledgeScore(Double parmScore)
        {
            if (double.IsNaN(parmScore)) { }
            else
                if (parmScore != 0.00)
                {
                    _knowledgescores.Add(parmScore);
                }
        }

        public void addSMSScore(Double parmScore)
        {
            if (double.IsNaN(parmScore)) { }
            else
                if (parmScore != 0.00)
                {
                    _smsscores.Add(parmScore);
                }
        }

        public List<double> TestScores = new List<Double>();
        public Double teststddev
        {
            get
            {
                TestScores.Clear();
                TestScores.Add(2.00);
                TestScores.Add(4.00);
                TestScores.Add(4.00);
                TestScores.Add(4.00);
                TestScores.Add(5.00);
                TestScores.Add(5.00);
                TestScores.Add(7.00);
                TestScores.Add(9.00);
                return stddev(TestScores);
            }
        }
    }
}
