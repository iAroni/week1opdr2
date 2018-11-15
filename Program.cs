using System;

namespace week1opdr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Question q1 = new Question();
            q1.setText("Who was the inventor of Java?");
            q1.setAnswer("James Gosling");

            q1.display();
            Console.WriteLine("Your answer: ");
            var antwoord = Console.ReadLine();
            Console.WriteLine(q1.checkAnswer(antwoord));
            Console.ReadLine();
        }
    }
}
