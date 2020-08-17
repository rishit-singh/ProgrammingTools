using System;

namespace CSharp_DebugTools
{
    class Program
    {
        static void Main(string[] args)
        {
            Debugger debugger = new Debugger("Test Debugger 0");

			debugger.StartConsole();
			
			debugger.Log("test log");  
        }
    }
}
