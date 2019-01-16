using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows;

using Person_ClassLib;


namespace PostMessages
{
    public class MessageOnBoard
    {
        
        public static void Main(string[] args)
        {
            Board board = new Board();

            board.AddUser("Ana", "Maria", "AnaM", new DateTime(1975, 10, 23));
            board.AddUser("Georgica", "Amari", "GeoA", new DateTime(1950, 08, 14));
            board.AddUser("Gica", "Koki", "GiK", new DateTime(1980, 6, 7));

            board.AddPost("GeoA", "Ana are mere.", DateTime.Now);
            Thread.Sleep(2000);
            board.AddPost("GiK", "Georgik e programator.", DateTime.Now);
            Thread.Sleep(2000);
            board.AddPost("AnaM", "Chiar am mere.", DateTime.Now);

            var messages = board.GetPosts().OrderByDescending(x => x.PostTime);

            foreach(var post in messages)
            {
                Console.WriteLine($"{post.UserName} ({post.PostTime}): {post.PostText}");
            }            
        }
    }

  

}
