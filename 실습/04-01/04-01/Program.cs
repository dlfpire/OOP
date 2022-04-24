﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    public delegate void MyEventHandler();
    class Button
    {
        public event MyEventHandler Push;
        public void OnPush()
        {
            if(Push != null)
                Push();
        }
    }
    class EventHandlerClass
    {
        public void MyMethod()
        {
            Console.WriteLine("In the EventHandlerClass.MyMethod ...");
        }
    }
    class Program
    {
        public static void Main()
        {
            Button button = new Button();
            EventHandlerClass obj = new EventHandlerClass();
            button.Push += new MyEventHandler(obj.MyMethod);
            button.OnPush();
        }
    }
}
