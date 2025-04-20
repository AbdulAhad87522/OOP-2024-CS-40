using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Songs
    {
        private string title;
        private List<Playlist> playlist;
        public Songs(string title)
        {
            this.title = title;
            playlist = new List<Playlist>();
        }
        public void addsongs(string content)
        {
            playlist.Add(new Playlist(content));
        }
        public void print()
        {
            Console.WriteLine($"Title : {title}");
            foreach (Playlist playlit in playlist)
            {
                playlit.print();
            }
        }
    }
}
