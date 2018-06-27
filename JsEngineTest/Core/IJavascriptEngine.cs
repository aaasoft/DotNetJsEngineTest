using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsEngineTest.Core
{
    public interface IJavascriptEngine
    {
        void Execute(string source);
    }
}
