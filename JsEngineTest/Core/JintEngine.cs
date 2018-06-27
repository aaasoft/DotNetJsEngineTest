using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsEngineTest.Core
{
    public class JintEngine : IJavascriptEngine
    {
        public void Execute(string source)
        {
            var engine = new Jint.Engine();
            engine.Execute(source);
        }
    }
}
