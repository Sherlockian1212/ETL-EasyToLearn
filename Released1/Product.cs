using System;
using System.Collections.Generic;
using FileHelpers;

namespace Released1
{
    [DelimitedRecord(",")]
    [IgnoreEmptyLines()]
    [IgnoreFirst()]
    class Product
    {
        string No;
        string TypeQuestion;
        string ContentQuestion;
        string TypeAnswer;
        string ListAnswer0, ListAnswer1, ListAnswer2, ListAnswer3;
        string CorrectAnswer;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string _No 
        { 
            get { return No; }
            set { No = value; }
        }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string _TypeQuestion
        {
            get { return TypeQuestion; }
            set { TypeQuestion = value; }
        }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string _ContentQuestion
        {
            get { return ContentQuestion; }
            set { ContentQuestion = value; }
        }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string _TypeAnswer
        {
            get { return TypeAnswer; }
            set { TypeAnswer = value; }
        }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string _Answer1
        {
            get { return ListAnswer0; }
            set { ListAnswer0 = value; }
        }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string _Answer2
        {
            get { return ListAnswer1; }
            set { ListAnswer1 = value; }
        }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string _Answer3
        {
            get { return ListAnswer2; }
            set { ListAnswer2 = value; }
        }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string _Answer4
        {
            get { return ListAnswer3; }
            set { ListAnswer3 = value; }
        }
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string _CorrectAnswer
        {
            get { return CorrectAnswer; }
            set { CorrectAnswer = value; }
        }
    }
}