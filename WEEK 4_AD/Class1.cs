using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_4_AD
{
    internal class Class1
    {
        private string nama;
        private string tempat;
        private string kota;
        public List<player> players = new List<player>();
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public string Tempat
        {
            get { return tempat; }
            set { tempat = value; }
        }
        public string Kota
        {
            get { return kota; }
            set { kota = value; }
        }

        public void nambah(player a)
        {
            players.Add(a);
        }
    }
    class player
    {
        private string playername;
        private string playernumber;
        private string playerposition;
        public string PlayerName
        {
            get { return playername; }
            set { playername = value; }
        }
        public string PlayerNumber
        {
            get { return playernumber; }
            set { playernumber = value; }
        }
        public string PlayerPosition
        {
            get { return playerposition; }
            set { playerposition = value; }
        }
    }
}
