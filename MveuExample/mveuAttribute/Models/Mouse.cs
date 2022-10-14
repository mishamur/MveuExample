using MveuExample.mveuAttribute.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MveuExample.mveuAttribute.Models
{
    [Pet]
    public class Mouse : AnimalBase
    {
        public Mouse(string name) : base(name)
        {
        }

        public override void SpeakAtConsole()
        {
            Console.WriteLine("Писк!");
        }
    }
}
