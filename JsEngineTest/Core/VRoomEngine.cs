using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsEngineTest.Core
{
    public class VRoomEngine : IJavascriptEngine
    {
        public void Execute(string source)
        {
            VroomJs.AssemblyLoader.EnsureLoaded();
            using (var engine = new VroomJs.JsEngine())
            {
                using (var context = engine.CreateContext())
                {
                    context.Execute(source);
                }
            }
        }
    }
}
