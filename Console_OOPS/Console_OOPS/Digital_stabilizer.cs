using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOPS
{
    class Digital_stabilizer
    {


        double _voltage;

        public double Voltage
        {
            get { return _voltage; }
        }

        public Digital_stabilizer()
        {

        }
        public string Digital_stabillizer()
        {
            string x = "";
            if (_voltage > 170 && _voltage > 470)
            {
                x = "CUT--OFF";
            }
            else if (_voltage >= 170 && _voltage <= 290)
            {
                x = "SINGLE--PHASE";
            }
            else if (_voltage > 290 && _voltage <= 340)
            {
                x = "SECOND--PHASE";
            }
            else if (_voltage > 340 && _voltage <= 470)
            {
                x = "THIRD--PHASE";
            }
            return x;
        }

        public Digital_stabilizer(double d)
        {
            this._voltage = d;
        }

        public override string ToString()
        {
            return string.Format("voltage: {0},status: {1}", this._voltage, this.Digital_stabillizer());
        }
    }
}
