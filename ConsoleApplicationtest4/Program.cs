using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerClass;

namespace ConsoleApplicationtest4
{
    class ReadProgram : Program 
    {
        public string NewColor()
        {
            string _newcolor;
            Program nP = new Program();
            _newcolor = nP.Color();
            Console.WriteLine(_newcolor);
            return _newcolor;
        }

    }
    class Program
    {
      
        static void Main(string[] args)
        {

            //int i;
            //i = 10;
            //Console.WriteLine(i);
            //Program P = new Program();
            //Console.WriteLine(P.Color());
            //Console.ReadKey();
            
            //ReadProgram rP = new ReadProgram();
            //Console.WriteLine(rP.NewColor());

            Console.ReadKey();
            ConsoleKeyInfo conKey = new ConsoleKeyInfo();
            char consoleKey = conKey.KeyChar;
            Console.WriteLine(consoleKey);
            Console.ReadLine();
            
            ColorSelector cs = new ColorSelector();
            String pickedColor = cs.ColorPick(consoleKey);
            Console.WriteLine(pickedColor);
            Console.ReadLine();
            
        }

        public string Color()
        {
            string _color;
            _color = "Blue";
            return _color;
        } 
    }
}
