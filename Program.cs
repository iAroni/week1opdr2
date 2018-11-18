using System;

namespace week1opdr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Question q1 = new Question()
            {
                text = "Wie is een baas?",
                answer = "Aron"
            };

            q1.display();
            Console.WriteLine("Your answer: ");
            var antwoord1 = Console.ReadLine();
            Console.WriteLine(q1.checkAnswer(antwoord1));
            

            Question q2 = new NumericQuestion();
            q2.setText("Hoe oud ben ik");
            q2.setAnswer("24");

            q2.display();
            Console.WriteLine("Your answer: ");
            var antwoord2 = Console.ReadLine();
            Console.WriteLine(q2.checkAnswer(antwoord2));
            Console.ReadLine();

        }
    }
}
