using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Moira_Sawyer
{
    // string with automatic properties for Brand, and Type.
    internal class Computer : IBootUp
    {
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        //Defines the PowerOnOff method and in the body.
        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if(IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is  shutting doun!");
            }
        }

        // an override function that returns a string and is called ToString.
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}!";
        }
    }
}
