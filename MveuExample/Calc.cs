using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MveuExample
{

    //приложение которое создаст инстанс этого класса, заполнит поля и вызовет метод/Reflection
    public class Calc
    {
        int left;
        int right;

        public Calc(int left, int right)
        {
            this.left = left;
            this.right = right;
        }

        public int Sub()
        {
            return left - right;
        }
        
        
    }
}
