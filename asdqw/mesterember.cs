using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdqw
{
    public class mesterember
    {

        public string név;
        public int napidíj;
       
        public bool [] foglaltnapok = new bool [31];
         


        public mesterember(string név, int napidíj)
        {
            this.név = név;
            this.napidíj = napidíj;
            this.foglaltnapok[31] = true;
        }

        public string MindenAdat()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(név);
            sb.Append("név:");
            sb.Append(foglaltnapok);
            sb.Append("foglaltnapok:");
            sb.Append(napidíj);
            sb.Append("napidíj:");

            for (int i = 0; i < 31; i++)
            {
                if (foglaltnapok[i] == true)

                {
                    sb.AppendLine();
                    sb.Append(".");
                    sb.Append("szabad");
                }
                else
                {
                    sb.AppendLine();
                    sb.Append("foglalt");
                }
            }   
            return sb.ToString();
        }

        public void MunkátVállal()
        {
            bool Munkátvállal = false;
            int i;
            StringBuilder sb1 = new StringBuilder();
            for (int k = 0; k < 31; k++)
                
            if (foglaltnapok[k] == true)

                {
                    Munkátvállal = true;
                    sb1.Append("Vállal");
                }
            else
                {
                    Munkátvállal = false;
                    sb1.Append("Nem vállal");
                }

        }
    }
}
