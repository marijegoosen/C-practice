using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_masterclass_
{
    //class derived from Post
    class ImagePost: Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUserName, string ImageURL, bool isPublic)
        {
            //the method is coming from Post class
            //properties inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUserName;
            this.IsPublic = isPublic;
            //property is member of this class
            this.ImageURL = ImageURL;
        }

        //override the override method from Post
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} by {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
}
