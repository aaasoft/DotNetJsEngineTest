using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsEngineTest
{
    public class Bridge
    {
        public void Test()
        {
            for(var i=0;i<10;i++)
            {
                var a = 123 + 456;
                var b = 456 + a;
                Console.WriteLine(b);
            }
        }
    }
}
