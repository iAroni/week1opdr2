using System;
using System.Collections.Generic;
using System.Text;

namespace week1opdr2
{
    class Question
    {
        private String text;
        private String answer;

        //set empty question
        public Question()
        {
            text = "";
            answer = "";
        }

        /**
        Sets the question text.
        @param questionText the text of this question
        */
        public void setText(String questionText)
        {
            text = questionText;
        }

        /**
        Sets the answer for this question.
        @param correctResponse the answer
        */
        public void setAnswer(String correctResponse)
        {
            answer = correctResponse;
        }

        /**
        Checks a given response for correctness.
        @param response the response to check
        @return true if the response was correct, false otherwise
        */
        public bool checkAnswer(String response)
        {
            return response.Equals(answer);
        }

        /**
        Displays this question.
        */
        public void display()
        {
            Console.WriteLine(text);
        }
    }
}
