using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple_Electrical_Switch s = new Simple_Electrical_Switch((Switch_name)Enum.Parse(typeof(Switch_name), "off"));
            Console.WriteLine(s.ToString());

            //Two_way_electrical_switch t = new Two_way_electrical_switch((switch_status)Enum.Parse(typeof(switch_status), "On"), (switch_status)Enum.Parse(typeof(switch_status), "On"));
            //Console.WriteLine(t.ToString());

            //Console.WriteLine("Enter Speed");
            //string a = Console.ReadLine();
            //Fan F = new Fan((Fanspeed)Enum.Parse(typeof(Fanspeed), a.ToLower()));
            //Console.WriteLine(F);

            //Digital_stabilizer d = new Digital_stabilizer(400);
            //Console.WriteLine(d.Digital_stabillizer());
        }
    }
}
