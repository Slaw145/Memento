using System;

namespace Mechanic
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();
            Mechanic mechanic = new Mechanic();
            mechanic.setState("The brake drum is in use. Begin of work");
            caretaker.addMemento(mechanic.save());
            mechanic.setState("The brake drum is available to use. End of work");
            mechanic.restore(caretaker.getMemento(0));

            Console.ReadLine();
        }
    }
}
