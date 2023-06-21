using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOPS
{
     public class Fan
    {
        Fanspeed speed;

        public Fanspeed Speed
        {
            get { return speed; }
        }

        public string three_speedfan()
        {
            string x = "";
            if (speed == Fanspeed.off)
            {
                x = "one";
            }
            else if (speed == Fanspeed.one)
            {
                x = "two";
            }
            else if (speed == Fanspeed.two)
            {
                x = "three";
            }
            else if (speed == Fanspeed.three)
            {
                x = "off";
            }
            return x;
        }

        public Fan()
        {

        }

        public override string ToString()
        {
            return string.Format("status: {0},Nextmove: {1}", this.speed, this.three_speedfan());
        }

        public Fan(Fanspeed F)
        {
            this.speed = F;
        }


    }

     public enum Fanspeed
     {
         off,
         one,
         two,
         three
     }
 }
