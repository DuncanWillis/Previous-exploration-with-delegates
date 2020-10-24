using System;
using System.Threading;

namespace TriviaEventDelegateGame
{
    public class AnswerEventArgs : EventArgs
    {
        public Answer Answer1 { get; set; }
    }

    public class DownloadHelper //Programming the Publisher
    {
        //Step 1 - Create a delegate
        public delegate void AnswerDownloadedEventHandler(object source, AnswerEventArgs args);
        //Step 2 - Create an event (of that delegate)
        public event AnswerDownloadedEventHandler AnswerDownloaded;
        //Step 3.0 - Prepare the raising of the event
        protected virtual void OnceAnswerDownloaded(Answer answer1)
        {
            if (AnswerDownloaded != null)
            {
                AnswerDownloaded(this, new AnswerEventArgs(){Answer1 = answer1 }); //??What is happening here?
            }
        }

        public void Thinking(Answer answer1)
        {
            Console.WriteLine("Thinking about the answer....");
            Thread.Sleep(2000);
            //Now RAISE the event(including the parameter that is being passed)
            OnceAnswerDownloaded(answer1);
        }

    }

    
}
