using System;
using System.Collections.Generic;

namespace MementoScheme
{
    public class MementoDemo
    {
        public static void Main(String[] args)
        {
            Caretaker caretaker = new Caretaker();
            Originator originator = new Originator();
            originator.setState("State1");
            originator.setState("State2");
            caretaker.addMemento(originator.save());
            originator.setState("State3");
            caretaker.addMemento(originator.save());
            originator.setState("State4");
            originator.restore(caretaker.getMemento(1));

            Console.ReadLine();
        }
    }
}
