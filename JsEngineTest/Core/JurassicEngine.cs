using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsEngineTest.Core
{
    public class JurassicEngine : IJavascriptEngine
    {
        public void Execute(string source)
        {
            var engine = new Jurassic.ScriptEngine();
            engine.Execute(source);
        }
    }
}
