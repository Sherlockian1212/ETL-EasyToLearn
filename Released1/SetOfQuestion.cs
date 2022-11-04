using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Packaging;

namespace Released1
{
    internal class SetOfQuestion
    {
        string strName;
        string strDescription;
        int iNumOfTime;
        int iNumOfQ;
        int iNumOfA;
        public List <QuestionAnswer> qa = new List<QuestionAnswer> ();
        double dScore;
        string strAddress;

        /* Get - Set */

        public string _strName
        {
            get { return strName; }
            set { strName = value; }
        }
        public string _strDescription
        {
            get { return strDescription; }
            set { strDescription = value; }
        }
        public int _iNumOfTime
        {
            get { return iNumOfTime; }
            set { iNumOfTime = value; }
        }
        public int _iNumOfQ
        {
            get { return iNumOfQ; }
            set { iNumOfQ = value; }
        }
        public int _iNumOfA
        {
            get { return iNumOfA; }
            set { iNumOfA = value; }
        }
        public double _dScore
        {
            get { return dScore; }
            set { dScore = value; }
        }
        public string _strAddress
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        
        /* Constructor */

        public SetOfQuestion()
        {
            strName = "";
            strDescription = "";
            iNumOfTime = 0;
            iNumOfQ = 0;
            iNumOfA = 0;
            dScore = 0.0;
            strAddress = "";
        }
        public SetOfQuestion(string strName, 
            string strDescription, 
            int iNumOfTime, 
            int iNumOfQ, 
            int iNumOfA, 
            double dScore, 
            string strAddress)
        {
            this.strName = strName;
            this.strDescription = strDescription;
            this.iNumOfTime = iNumOfTime;
            this.iNumOfQ = iNumOfQ;
            this.iNumOfA = iNumOfA;
            this.dScore = dScore;
            this.strAddress = strAddress;
        }
        public SetOfQuestion(SetOfQuestion soq)
        {
            strName = soq.strName;
            strDescription = soq.strDescription;    
            iNumOfTime = soq.iNumOfTime;
            iNumOfQ = soq.iNumOfQ;
            iNumOfA = soq.iNumOfA;
            dScore = soq.dScore;
            strAddress = soq.strAddress;
        }
        
        /* Truy xuất câu hỏi theo iKey */
        public QuestionAnswer access(int iKey) 
        {
            QuestionAnswer a = new QuestionAnswer();
            return a;
        }
        public void checkFile(string Path)
        {
            var engine = new FileHelperEngine(typeof(Product));
            var products = (Product[])engine.ReadFile(Path);
        }
        public void newFile()
        {
            string path = Application.StartupPath + @"\\SOQ\" + strName.Trim() + ".csv";
            StringBuilder output = new StringBuilder();
            int i = 0;
            string[] content = { "No","TypeQuestion","ContentQuestion","TypeAnswer","0","1","2","3","CorrectAnswer" };
            output.AppendLine(string.Join(",", content));
            File.AppendAllText(path, output.ToString());
            foreach (QuestionAnswer question in qa)
            {
                string[] data = { i.ToString(), "text", question._strContentQuestion, "text", question._strListAnswer[0], question._strListAnswer[1], question._strListAnswer[2], question._strListAnswer[3], question._iCorrectAnswer.ToString() };
                output.AppendLine(string.Join(",", data));
                File.AppendAllText(path, output.ToString());
                i++;
            }
            
        }
    }
}
