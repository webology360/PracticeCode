using System;

namespace EventDelegatePublisherSubcriber
{
    //Video encorder is a publisher for a event "VideoEncoded"
    //which will be rasied when video is encoded 

    public class VideoEventArgs: EventArgs
    {
        public string videoName;
    }
}
