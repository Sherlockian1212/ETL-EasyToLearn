using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Released1
{
    internal class Test
    {
        string strName;
        string strAddress;
        int iNumOfQ;
        List <QuestionAnswer> qaListQuestionAnswer;
        List <int> iUserAnswer;
        DateTime dtTime;
        DateTime dtTimeLimit;
        double dScore;
        double dMaxScore;
        double dSumScore;

        /* Get - Set */

        public string _strName
        {
            get { return strName; }
            set { strName = value; }
        }
        public string _strAddress
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        public int _iNumOfQ
        {
            get { return iNumOfQ; }
            set { iNumOfQ = value; }
        }
        public List<QuestionAnswer> _qaListQuestionAnswer
        {
            get { return qaListQuestionAnswer; }
            set { qaListQuestionAnswer = value; }
        }
        public List<int> _iUserAnswer
        {
            get { return iUserAnswer; }
            set { iUserAnswer = value; }
        }
        public DateTime _dtTime
        {
            get { return dtTime; }
            set { dtTime = value; }
        }
        public DateTime _TimeLimit
        {
            get { return dtTimeLimit; }
            set { dtTimeLimit = value; }
        }
        public double _dScore
        {
            get { return dScore; }
            set { dScore = value; }
        }
        public double _dMaxScore
        {
            get { return dMaxScore; }
            set { dMaxScore = value; }
        }
        public double _dSumScore
        {
            get { return dSumScore; }
            set { _dSumScore = value; }
        }

        /* Constructor */

        public Test()
        {
            strName = "";
            strAddress = "";
            iNumOfQ = 0;
            qaListQuestionAnswer = new List<QuestionAnswer>();
            iUserAnswer = new List<int>();
            dtTime = new DateTime();
            dtTimeLimit = new DateTime();
            dScore = 0;
            dMaxScore = 0;
            dSumScore = 0;
        }
        public Test(string strName, 
            string strAddress, 
            int iNumOfQ, 
            List <QuestionAnswer> qaListQuestionAnswer, 
            List <int> iUserAnswer, 
            DateTime dtTime, 
            DateTime dtTimeLimit, 
            double dScore, 
            double dMaxScore, 
            double dSumScore)
        {
            this.strName = strName;
            this.strAddress = strAddress;
            this.iNumOfQ = iNumOfQ;
            this.qaListQuestionAnswer = qaListQuestionAnswer;
            this.iUserAnswer = iUserAnswer;
            this.dtTime = dtTime;
            this.dtTimeLimit = dtTimeLimit;
            this.dScore = dScore;
            this.dMaxScore = dMaxScore;
            this.dSumScore = dSumScore;
        }
        public Test (Test t)
        {
            strName = t.strName;
            strAddress = t.strAddress;
            iNumOfQ = t.iNumOfQ;
            qaListQuestionAnswer = t.qaListQuestionAnswer;
            iUserAnswer = t.iUserAnswer;
            dtTime = t.dtTime;
            dtTimeLimit = t.dtTimeLimit;
            dScore = t.dScore;
            dMaxScore = t.dMaxScore;
            dSumScore = t.dSumScore;
        }
    }
}
