using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsEngineTest
{
    public class Bridge
    {
        private Action action;
        public Bridge(Action action)
        {
            this.action = action;
        }
        public void Invoke()
        {
            action();
        }
    }
}
