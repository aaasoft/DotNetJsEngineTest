using JavaScriptEngineSwitcher.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsEngineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var testSourceCode = @"
for(var i=0;i<100000000;i++){
    var a = Math.PI * Math.E;
    a/= Math.E;
}
";
            Dictionary<string, IJsEngine> dict = new Dictionary<string, IJsEngine>()
            {
                [@"VRoom
------------
Engine: V8
Platform: All"] = new JavaScriptEngineSwitcher.Vroom.VroomJsEngine(),
                [@"ChakraCore
------------
Engine: Chakra
Platform: Windows x86,Windows x64,Windows ARM,Linux x64"] = new JavaScriptEngineSwitcher.ChakraCore.ChakraCoreJsEngine(),
                [@"ClearScript.V8
------------
Engine: V8
Platform: Windows Only"] = new JavaScriptEngineSwitcher.V8.V8JsEngine(),
[@"Jurassic
------------
Engine: Jurassic
Platform: All"] = new JavaScriptEngineSwitcher.Jurassic.JurassicJsEngine(),
                [@"NiL
------------
Engine: Nil
Platform: All"] = new JavaScriptEngineSwitcher.NiL.NiLJsEngine(),
                [@"Jint
------------
Engine: Jint
Platform: All"] = new JavaScriptEngineSwitcher.Jint.JintJsEngine()
            };

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            foreach (var key in dict.Keys)
            {
                
                Console.WriteLine($"{key}");
                var engine = dict[key];
                stopwatch.Restart();
                engine.Execute(testSourceCode);
                stopwatch.Stop();
                Console.WriteLine($"UsedTime(ms): {stopwatch.ElapsedMilliseconds}");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
