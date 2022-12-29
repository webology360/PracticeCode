using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegatePublisherSubcriber
{
    //Subscriber
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs videoEventArgs)
        {
            Console.WriteLine("MailService: Got event for video " + videoEventArgs.videoName + " from source " + source.ToString());
            Console.WriteLine("MailService: Sending an email...");
        }
    }
}
