using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MveuExample.mveuAttribute.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class VoicePetAttribute : Attribute
    {
    }
}
