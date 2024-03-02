using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practise
{
    internal class Song
    {
        public String title;
        public String artist;
        public int duration;
        public static int songCount = 0;
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }
        public int getSongCount() 
        {
            return songCount;
        }
    }
}
