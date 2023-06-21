using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOPS
{
    public class Two_way_electrical_switch
    {
        
        switch_status _switch1_type;

        public switch_status Switch1_type
        {
            get { return _switch1_type; }
        }


        switch_status _switch2_type;

        public switch_status Switch2_type
        {
            get { return _switch2_type; }
        }

        public string On_Off_switch()
        {
            string x = "";
            if (_switch1_type == switch_status.On && _switch2_type == switch_status.On)
            {
                x = "Off";
            }
            else if (_switch1_type == switch_status.Off && _switch2_type == switch_status.Off)
            {
                x = "Off";
            }
            else if (_switch1_type == switch_status.On && _switch2_type == switch_status.Off)
            {
                x = "On";
            }
            else if (_switch1_type == switch_status.Off && _switch2_type == switch_status.On)
            {
                x = "On";
            }
            return x;

        }
        public Two_way_electrical_switch(switch_status ss, switch_status s)
        {
            this._switch1_type = ss;
            this._switch2_type = s;
        }

        public override string ToString()
        {
            return string.Format("Switch1: {0},Switch2: {1},Status: {2}",this._switch1_type,this._switch2_type,this.On_Off_switch());
        }
    }
    public enum switch_status
    {
        On,
        Off
    }
}
