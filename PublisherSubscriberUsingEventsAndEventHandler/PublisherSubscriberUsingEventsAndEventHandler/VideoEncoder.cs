using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventDelegatePublisherSubcriber
{


    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event

        //It is convention to put delegate name as "EventName"+"EventHandler"
        //public delegate void VideoEncodedEventHandler(Object sourse, VideoEventArgs args);

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video.videoName);
        }
        
        protected virtual void OnVideoEncoded(string videoName)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() {videoName=videoName });//Send data to subscriber
        }
    }
}
