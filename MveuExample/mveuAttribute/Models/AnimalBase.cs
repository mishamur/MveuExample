using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MveuExample.mveuAttribute.Models
{
    public abstract class AnimalBase
    {
        protected string name;

        protected AnimalBase(string name)
        {
            this.name = name;
        }

        public virtual void SpeakAtConsole() { }
        public string GetName()
        {
            return name;
        }


    }
}
