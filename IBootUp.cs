using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Moira_Sawyer
{
    interface IBootUp
    {

        // a boolean property with an automatic getter and setter to the interface.
        public bool IsOn { get; set; }

        //declares a method in the interface.
        public void PowerOnOff();
    }
}
