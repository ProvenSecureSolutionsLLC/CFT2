using System;
using System.Collections.Generic;
using System.Linq;
using LinqLib.Operators;
using System.Text;
using System.Threading.Tasks;

namespace Bench
{
    class class_highlowsession
    {
        // use the data gathered in to here to generate more authentication session results for each user
        public string user { get; set; }
        public string character { get; set; }

        public DateTime startdatetime_earliest { get; set; }
        public DateTime enddatetime_latest { get; set; }

        public Double _pwmin { get; set; }
        public Double _pwmax { get; set; }
        public Double _pwmean { get; set; }
        public Double _pwstddevsum { get; set; }
        public Double _pwstddev { get; set; }
        public Double _pwsum { get; set; }
        public int _pwcount { get; set; }

        public Double _attvoicemin { get; set; }
        public Double _attvoicemax { get; set; }
        public Double _attvoicemean { get; set; }
        public Double _attvoicestddevsum { get; set; }
        public Double _attvoicestddev { get; set; }
        public Double _attvoicesum { get; set; }
        public int _attvoicecount { get; set; }

        public Double _attfacemin { get; set; }
        public Double _attfacemax { get; set; }
        public Double _attfacemean { get; set; }
        public Double _attfacestddevsum { get; set; }
        public Double _attfacestddev { get; set; }
        public Double _attfacesum { get; set; }
        public int _attfacecount { get; set; }

        public Double _betafacemin { get; set; }
        public Double _betafacemax { get; set; }
        public Double _betafacemean { get; set; }
        public Double _betafacestddevsum { get; set; }
        public Double _betafacestddev { get; set; }
        public Double _betafacesum { get; set; }
        public int _betafacecount { get; set; }

        public Double _knowledgemin { get; set; }
        public Double _knowledgemax { get; set; }
        public Double _knowledgemean { get; set; }
        public Double _knowledgestddevsum { get; set; }
        public Double _knowledgestddev { get; set; }
        public Double _knowledgesum { get; set; }
        public int _knowledgecount { get; set; }

        public Double _smsmin { get; set; }
        public Double _smsmax { get; set; }
        public Double _smsmean { get; set; }
        public Double _smsstddevsum { get; set; }
        public Double _smsstddev { get; set; }
        public Double _smssum { get; set; }
        public int _smscount { get; set; }

        public void init()
        {
            user = "Default";
            character = "Blank";
            _pwmax = 0.00;
            _pwmin = 9.9999;
            _pwcount = 0;
            _pwstddevsum = 0.00;
            _pwmean = 0.00;

            _attvoicemax = 0.00;
            _attvoicemin = 9.9999;
            _attvoicecount = 0;
            _attvoicestddevsum = 0.00;
            _attvoicemean = 0.00;

            _attfacemax = 0.00;
            _attfacemin = 9.9999;
            _attfacecount = 0;
            _attfacestddevsum = 0.00;
            _attfacemean = 0.00;

            _betafacemax = 0.00;
            _betafacemin = 9.9999;
            _betafacecount = 0;
            _betafacestddevsum = 0.00;
            _betafacemean = 0.00;

            _knowledgemax = 0.00;
            _knowledgemin = 9.9999;
            _knowledgecount = 0;
            _knowledgestddevsum = 0.00;
            _knowledgemean = 0.00;

            _smsmax = 0.00;
            _smsmin = 9.9999;
            _smscount = 0;
            _smsstddevsum = 0.00;
            _smsmean = 0.00;
        }

        public class_highlowsession(string parmUser, string parmCharacter)
        {
            init();
            user = parmUser;
            character = parmCharacter;
        }

        public void addPWScore(Double parmScore)
        {
            if ((parmScore != 0.00)&&(parmScore != Double.NaN))
            {
                _pwcount++;
                _pwsum += parmScore;
                if (parmScore < _pwmin) { _pwmin = parmScore; }
                if (parmScore > _pwmax) { _pwmax = parmScore; }
                Double delta = parmScore - _pwmean;
                _pwmean += delta / _pwcount;
                _pwstddevsum += delta * (parmScore - _pwmean);
            }
            if (1 < _pwcount)
            {
                _pwstddev = Math.Sqrt(_pwstddevsum / (_pwcount - 1));
            }
        }

        public void addATTVoiceScore(Double parmScore)
        {
            if ((parmScore != 0.00)&&(parmScore != Double.NaN))
            {
                _attvoicecount++;
                _attvoicesum += parmScore;
                if (parmScore < _attvoicemin) { _attvoicemin = parmScore; }
                if (parmScore > _attvoicemax) { _attvoicemax = parmScore; }
                Double delta = parmScore - _attvoicemean;
                _attvoicemean += delta / _attvoicecount;
                _attvoicestddevsum += delta * (parmScore - _attvoicemean);
            }
            if (1 < _attvoicecount)
            {
                _attvoicestddev = Math.Sqrt(_attvoicestddevsum / (_attvoicecount - 1));
            }
        }

        public void addATTFaceScore(Double parmScore)
        {
            if ((parmScore != 0.00) && (parmScore != Double.NaN))
            {
                _attfacecount++;
                _attfacesum += parmScore;
                if (parmScore < _attfacemin) { _attfacemin = parmScore; }
                if (parmScore > _attfacemax) { _attfacemax = parmScore; }
                Double delta = parmScore - _attfacemean;
                _attfacemean += delta / _attfacecount;
                _attfacestddevsum += delta * (parmScore - _attfacemean);
            }
            if (1 < _attfacecount)
            {
                _attfacestddev = Math.Sqrt(_attfacestddevsum / (_attfacecount - 1));
            }
        }

        public void addBetafaceScore(Double parmScore)
        {
            if ((parmScore != 0.00) && (parmScore != Double.NaN))
            {
                _betafacecount++;
                _betafacesum += parmScore;
                if (parmScore < _betafacemin) { _betafacemin = parmScore; }
                if (parmScore > _betafacemax) { _betafacemax = parmScore; }
                Double delta = parmScore - _betafacemean;
                _betafacemean += delta / _betafacecount;
                _betafacestddevsum += delta * (parmScore - _betafacemean);
            }
            if (1 < _betafacecount)
            {
                _betafacestddev = Math.Sqrt(_betafacestddevsum / (_betafacecount - 1));
            }
        }

        public void addKnowledgeScore(Double parmScore)
        {
            if ((parmScore != 0.00) && (parmScore != Double.NaN))
            {
                _knowledgecount++;
                _knowledgesum += parmScore;
                if (parmScore < _knowledgemin) { _knowledgemin = parmScore; }
                if (parmScore > _knowledgemax) { _knowledgemax = parmScore; }
                Double delta = parmScore - _knowledgemean;
                _knowledgemean += delta / _knowledgecount;
                _knowledgestddevsum += delta * (parmScore - _knowledgemean);
            }
            if (1 < _knowledgecount)
            {
                _knowledgestddev = Math.Sqrt(_knowledgestddevsum / (_knowledgecount - 1));
            }
        }

        public void addSMSScore(Double parmScore)
        {
            if ((parmScore != 0.00) && (parmScore != Double.NaN))
            {
                _smscount++;
                _smssum += parmScore;
                if (parmScore < _smsmin) { _smsmin = parmScore; }
                if (parmScore > _smsmax) { _smsmax = parmScore; }
                Double delta = parmScore - _smsmean;
                _smsmean += delta / _smscount;
                _smsstddevsum += delta * (parmScore - _smsmean);
            }
            if (1 < _smscount)
            {
                _smsstddev = Math.Sqrt(_smsstddevsum / (_smscount - 1));
            }
        }
    }
}
