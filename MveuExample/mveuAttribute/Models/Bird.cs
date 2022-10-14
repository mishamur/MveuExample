using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MveuExample.mveuAttribute.Models
{
    public class Bird : AnimalBase
    {
        public Bird(string name) : base(name)
        {
        }

        public override void SpeakAtConsole()
        {
            Console.WriteLine("чирик-чирик");
        }
    }
}
