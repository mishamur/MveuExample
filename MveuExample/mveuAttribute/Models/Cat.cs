using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MveuExample.mveuAttribute.Attributes;
namespace MveuExample.mveuAttribute.Models
{

    [Pet]
    public class Cat : AnimalBase
    {
        public Cat(string name) : base(name)
        {
        }

        [VoicePet]
        public override void SpeakAtConsole()
        {
            Console.WriteLine("мяу");
        }
    }
}
