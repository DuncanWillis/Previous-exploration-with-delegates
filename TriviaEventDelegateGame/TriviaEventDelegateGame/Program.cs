using System;

namespace TriviaEventDelegateGame
{
    class Program
    {
        public static void Country(int input, object country)
        {
            Console.WriteLine("Choose 1 of the following countries and enter the number");
            Console.WriteLine("1.England, 2.France, 3.Germany, 4.Japan");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1: country = "England"; break;
                case 2: country = "France"; break;
                case 3: country = "Germany"; break;
                case 4: country = "Japan"; break;

            }
            Console.WriteLine("Hmmmmm, what is the capital of {0}?" + country);
            string input1 = Console.ReadLine();

        }

        static void Main(string[] args)
        {



            var answer1 = new Answer() { Title = "London" };
            var answer2 = new Answer() { Title = "Paris" };
            var answer3 = new Answer() { Title = "Berlin" };
            var answer4 = new Answer() { Title = "Tokyo" };
            var downloadHelper = new DownloadHelper(); //the publisher
            var unpackService = new UnpackService(); //the reciever
            downloadHelper.AnswerDownloaded += unpackService.OnceAnswerDownloaded;

            downloadHelper.Thinking(answer1);
        }

    
        
    }
}
