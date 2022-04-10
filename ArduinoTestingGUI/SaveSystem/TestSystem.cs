using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ArduinoTestingGUI;
using System.Windows.Controls;
using System.IO;
using ArduinoTestingGUI.Components.Input;

namespace ArduinoTestingGUI.SaveSystem
{
    interface IGlobal
    {
        int id { get; set; }
        string name { get; set; }
    }

    interface IO : IGlobal
    {

    }

    interface IN : IGlobal
    {
        
    }

    class a : IN
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ledName { get; set; }
    }

    class b : IN
    {
        public int id { get; set; }
        public string name { get; set; }
        public string motorName { get; set; }

    }

    class aa : IO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ledName { get; set; }
    }

    class bb : IO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string motorName { get; set; }

    }

    class big
    {
        public List<object> _input = new List<object>();
        public List<object> _output = new List<object>();

    }

    /*class main2
    {
        static public List<List<IGlobal>> _global = new List<List<IGlobal>>()
        {
            
        };

        List<IN> input = new List<IN>()
        {
            new a() { id=1, name="led name", ledName="led1" },
            new b() { id=2, name="motor name", motorName="led1" },
        };

        public void func()
        {
            //_global.Add(input);
        }
    }*/

    static class TestSystem
    {
        //public static List<Code> co = new List<Code>();

        private static big _big = new big();

        public static void AddInput(object obj)
        {
            _big._input.Add(obj);
        }

        public static void AddOutput(object obj)
        {
            _big._output.Add(obj);
        }

        public static void writeJson(string location)
        {
            /*a _a = new a();
            _a.id = 1;
            _a.name = "name";
            _a.ledName = "a";

            big _big = new big();*/
            /*_big._input.Add(new a() { id = 1, name = "led name", ledName = "led1" });
            _big._input.Add(new b() { id = 1, name = "led name", motorName = "led1" });
            _big._output.Add(new bb() { id = 1, name = "led name", motorName = "led1" });
            _big._output.Add(new aa() { id = 1, name = "led name", ledName = "led1" });*/
            //big._input.Add(new a() { id = 1, name = "led name", ledName = "led1" });

            //_big.addInput<a>(_a);

            //string json = JsonConvert.SerializeObject(_big);
            string json = JsonConvert.SerializeObject(_big);
            File.WriteAllText(location, json);
        }
    }
}
