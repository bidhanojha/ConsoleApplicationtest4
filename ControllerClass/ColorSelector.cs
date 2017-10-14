using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ControllerClass
{
    public class ColorSelector
    {
        public string ColorPick(char inputColor)
        {
            if (inputColor == 'P')
            return "Pink";
            else if (inputColor == 'G')
                return "Green";
            else
            {
                return "No Match";
            }

        }
    }
}
