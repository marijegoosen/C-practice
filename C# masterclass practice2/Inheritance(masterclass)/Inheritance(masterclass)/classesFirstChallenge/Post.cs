using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_masterclass_
{
    class Post
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        //default constructor
        public Post()
        {
            ID = 0;
            Title = "my first post";
            IsPublic = true;
            SendByUsername = "Marije Goosen";
        }

        //instance constructor that has 3 parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        //method to create the ID automatically
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        //method to update the title and if the post is public or not
        //the sendByUserName should not be updatable because you are always going to be you
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //virtual method override of the ToString method that is inherited from System.Object
        public override string ToString()
        {
            //returns whatever the baseclass returns
            //return base.ToString();

            return String.Format("{0} - {1} by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
