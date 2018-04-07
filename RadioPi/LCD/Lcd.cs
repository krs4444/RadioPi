using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadioPi.MCP;

namespace RadioPi.LCD
{
    public sealed class Lcd
    {
        readonly MCP23017 mCP23017;

        public Lcd(MCP23017 mCP23017)
        {
            this.mCP23017 = mCP23017;
        }
    }
}
