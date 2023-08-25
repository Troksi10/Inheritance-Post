using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Post
{
    class Post
    {
        private static int currentPostId;

        // properties

        protected int ID { get; set; }

        public string Title { get; set; }

        public string SendByUsername { get; set; }

        public bool IsPublic { get; set; }

        // Default constructor
        public Post() { 
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Ilija Trokovski";

        }

        // Instance constructor

        public Post(string title,bool isPublic,string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title,bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}",this.ID,this.Title,this.SendByUsername);
        }

    }
}
