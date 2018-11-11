using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance_masterclass_
{
    class VideoPost: Post
    {
        //part of the more challenging
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUserName, string videoURL,int length, bool isPublic)
        {
            //the method is coming from Post class
            //properties inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUserName;
            this.IsPublic = isPublic;
            //property is member of this class
            this.VideoURL = videoURL;
            this.Length = length;
        }

        //override the override method from Post
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} ({3} seconds long) by {4}", this.ID, this.Title, this.VideoURL,this.Length, this.SendByUsername);
        }

        //method as part of the more challenging part
        public void Play()
        {
            //if the video is playing, call the timer
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        //method as part of the more challenging part
        //timer method
        private void TimerCallback(Object o)
        {
            if(currDuration< Length)
            {
                currDuration++;
                Console.WriteLine("video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        //method as part of the more challenging part
        public void Stop()
        {
            //only be able to stop the video if it is playing
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0} seconds", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

    }
}
