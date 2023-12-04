﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Converter
    {
        private double usdRate;
        private double eurRate;
        private double plnRate;

        public Converter(double usd, double eur, double pln)
        {
            this.usdRate = usd;
            this.eurRate = eur;
            this.plnRate = pln;
        }        
        public double ConvertToEur(double uah)
        {
            return uah / eurRate;
        }
        public double ConvertToUsd(double uah)
        {
            return uah / usdRate;
        }
        public double ConvertToPln(double uah)
        {
            return uah / plnRate;
        }
        public double ConvertFromEur(double eur)
        {
            return eur * eurRate;
        }
        public double ConvertFromUsd(double usd)
        {
            return usd * usdRate;
        }
        public double ConvertFromPln(double pln)
        {
            return pln * plnRate;
        }
    }
}
