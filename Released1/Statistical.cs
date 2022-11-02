using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Released1
{
    internal class Statistical
    {
        public static int iCount = 0;
        public static List <string> strName = new List<string>();
        public static List <double> dScore = new List<double>();
        public static double dMaxScore = 0;

        /* Get - Set */
        
        public int _iCount
        {
            get { return iCount; }
            set { iCount = value; }
        }
        public List <string> _strName
        {
            get { return strName; }
            set { strName = value; }
        } 
        public List<double> _dScore
        {
            get { return dScore; }
            set { dScore = value; }
        }
        public double _dMaxScore
        {
            get { return dMaxScore; }
            set { dMaxScore = value; }
        }
        
        /* Constructor */

        public Statistical()
        {
            iCount = 0;
            strName = new List <string> ();
            dScore = new List <double> ();
            dMaxScore = 0.0;
        }
        /*
        public Statistical(int iCount, List<string> strName, List<double> dScore, double dMaxScore)
        {
            this.iCount = iCount;
            this.strName = strName;
            this.dScore = dScore;
            this.dMaxScore = dMaxScore;
        }
        public Statistical(Statistical statistical)
        {
            iCount = statistical.iCount;
            dScore = statistical.dScore;
            dMaxScore = statistical.dMaxScore;
        }
        */
        
    }
}
