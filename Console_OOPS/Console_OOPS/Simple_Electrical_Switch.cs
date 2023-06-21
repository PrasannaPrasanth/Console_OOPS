using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOPS
{
    class Simple_Electrical_Switch
    {
        Switch_name _switchtype;

        public Switch_name Switchtype
        {
            get { return _switchtype; }
            set { _switchtype = value; }
        }


        public string on_off_switch()
        {
            string state = "";
            if(_switchtype==Switch_name.On)
            {
                state="off";
            }
            else if (_switchtype == Switch_name.off)
            {
                state="On";
            }
            return state;
        }

        public  Simple_Electrical_Switch(Switch_name sw)
        {
            this._switchtype = sw;
        }
   
        public  Simple_Electrical_Switch()
        {
            
        }

        public override string ToString()
        {
            return string.Format("Switch: {0},Status: {1}", this._switchtype, this.on_off_switch());
        }
    }
    public enum Switch_name
    {
        On,
        off
    }
}
