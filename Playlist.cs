using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_3_Shengals_Roman
{
    class Playlist
    {
        struct Song
        {
            public string Author;
            public string Title;
            public string Filename;
        }
        private List<Song> list;
        private int currentIndex;

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }
    }
}
