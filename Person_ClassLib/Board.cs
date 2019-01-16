using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_ClassLib
{
    public class Board
    {
        private List<Person> users = new List<Person>();
        private List<Post> posts = new List<Post>();

        public void AddUser(string userFirstName, string userLastName, string userName, DateTime birtday)
        {
            Person user = new Person( userFirstName,  userLastName,  userName,  birtday);

            users.Add(user);

        }

        public void AddPost(string userName, string postText, DateTime postTime)
        {
            var message = new Post(userName, postText, postTime);

            posts.Add(message);

        }

        public List<Post> GetPosts()
        {
            return posts;
        }

 

    }
}
