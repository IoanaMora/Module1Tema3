using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_ClassLib
{
    public class Post
    {
        public string UserName { get; set; }
        public string PostText { get; set; }
        public DateTime PostTime { get; set; }

        public Post(string userName, string postText, DateTime postTime)
        {
            UserName = userName;
            PostText = postText;
            PostTime = postTime;
        }
    }
}
