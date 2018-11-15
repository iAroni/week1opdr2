using System;
using System.Collections.Generic;
using System.Text;

namespace week1opdr2
{
    class NumericQuestion : Question
    {
        double answer;

        public override void setAnswer(string correctResponse)
        {
            double antwoord = double.Parse(correctResponse);
            answer = antwoord;
        }

        public override bool checkAnswer(string response)
        {
            double cAnswer = double.Parse(response);
            return response.Equals(answer);
        }

    }
}
