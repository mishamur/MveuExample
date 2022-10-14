using MveuExample.mveuAttribute.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MveuExample.mveuAttribute.Models
{
    [Pet]
    public class Dog : AnimalBase
    {
        public Dog(string name) : base(name)
        {
        }

        [VoicePet]
        public override void SpeakAtConsole()
        {
            Console.WriteLine("гаф");
        }
    }
}
