using System;

namespace EventDelegatePublisherSubcriber
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { videoName = "video1", videoPath = "https://www.abc.com/video1.mp4" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            
            //Subscriber to subcribe to the publisher,
            //Great thing to note is thar both subscriber and publisher
            //are not tightly coupled.

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);
            Console.Read();
        }
    }
}
