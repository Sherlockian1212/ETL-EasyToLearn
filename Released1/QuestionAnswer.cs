using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Released1
{
    internal class QuestionAnswer
    {
        string strTypeQuestion;
        string strContentQuestion;
        string strTypeAnswer;
        int iNumChoose;
        List <string> strListAnswer;
        int iCorrectAnswer;

        /* Get - Set*/

        public string _strTypeQuestion
        {
            get { return strTypeQuestion; }
            set { strTypeQuestion = value; }
        }
        public string _strContentQuestion
        {
            get { return strContentQuestion; } 
            set { strContentQuestion = value; }
        }
        public string _strTypeAnswer
        {
            get { return strTypeAnswer; }
            set { strTypeAnswer = value; }
        }
        public int _iNumChoose
        {
            get { return iNumChoose; }
            set { iNumChoose = value; }
        }
        public List <string> _strListAnswer
        {
            get { return strListAnswer; }
            set { strListAnswer = value; }
        }
        public int _iCorrectAnswer
        {
            get { return iCorrectAnswer; }
            set { iCorrectAnswer = value; }
        }

        /* Constructor */

        public QuestionAnswer()
        {
            strTypeQuestion = "";
            strContentQuestion = "";
            strTypeAnswer = "";
            iNumChoose = 0;
            strListAnswer = new List<string> { "","","",""};
            iCorrectAnswer = -1;
        }
        public QuestionAnswer(string strTypeQuestion, 
            string strContentQuestion, 
            string strTypeAnswer, 
            int iNumChoose, 
            List <string> strListAnswer, 
            int iCorrectAnswer)
        {
            this.strTypeQuestion = strTypeQuestion;
            this.strContentQuestion = strContentQuestion;
            this.strTypeAnswer = strTypeAnswer;
            this.iNumChoose = iNumChoose;
            this.strListAnswer = strListAnswer;
            this.iCorrectAnswer = iCorrectAnswer;
        }
        public QuestionAnswer(QuestionAnswer qa)
        {
            strTypeQuestion = qa.strTypeQuestion;
            strContentQuestion = qa.strContentQuestion;
            strTypeAnswer = qa.strTypeAnswer;
            iNumChoose = qa.iNumChoose;
            strListAnswer = qa.strListAnswer;   
            iCorrectAnswer = qa.iCorrectAnswer;
        }


    }

}
