using System;
namespace TriviaEventDelegateGame
{
    public class UnpackService
    {
        public void OnceAnswerDownloaded(object source, AnswerEventArgs e)
        {
            Console.WriteLine(e.Answer1.Title);
            //Event Args as of yet does not contain the method 'Answer', so we can create a new EventArgs 
        }
    }
}
