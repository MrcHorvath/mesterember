using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdqw
{
    class burkoló : mesterember
    {
        

        public burkoló(string név, int napidíj) : base(név, napidíj)
        {
            base.név = név;
            base.foglaltnapok = foglaltnapok;
            base.napidíj = napidíj;
        }

        private string szakterület;

        public string Szakterület
        {
            get
            {
                if (Szakterület = Belső)
                return Belső;
            }
            set
            {
                
                return külső;
            }
        }

        public void Összesszabadnap()
        {
            int x = 0;
            for (int i = 0; i < 31; i++)
                if (foglaltnapok[i] == true)
                   x++ ;
            return;
        }
        
        public void MindenAdat()
        {
            
        }

        public void MunkátVállal()
        {
            
        }
    }
}
