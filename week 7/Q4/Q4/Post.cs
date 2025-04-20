using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Post
    {
        public string name;
        public List<Comments> comments;
        public List<Like> like;
        public List<Follower> follower;
        public Post() { }
        public Post(string name)
        {
            this.name = name;
            comments = new List<Comments>();
            like = new List<Like>();
            follower = new List<Follower>();
        }
        public void addcomment(string compliment ,bool lik , Follower f )
        {
            comments.Add(new Comments(compliment));
            like.Add(new Like(lik));
            follower.Add(f);
        }
        public void print()
        {
            Console.WriteLine($"the post: {name}");
            Console.WriteLine(" ");
            Console.WriteLine("Comments: ");
            foreach(Comments c in comments)
            {
                 c.print();
            }
            Console.WriteLine(" ");
            Console.WriteLine("Likes status");

            foreach (Like l in like)
            {
                l.print();
            }
            Console.WriteLine(" ");

            Console.WriteLine("Followers: ");
            foreach(Follower f in follower)
            {
                f.print();
            }
        }
    }
}
