using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsEngineTest.Core
{
    public class ClearScriptV8Engine : IJavascriptEngine
    {
        public void Execute(string source)
        {
            var v8Runtime = new Microsoft.ClearScript.V8.V8Runtime();
            var engine = v8Runtime.CreateScriptEngine();
            engine.Execute(source);
        }
    }
}
