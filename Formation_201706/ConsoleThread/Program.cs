using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleThread {
    class Program {
        static void Main(string[] args) {
            Thread omar = new Thread(JobToDo);
            omar.Name = "Omar";
            Thread fred = new Thread(JobToDo);
            fred.Name = "Fred";
            omar.Start(400);
            fred.Start(800);
            Console.WriteLine("Début du main");
            JobToDo(100);
            Console.WriteLine("J'ai fini...");
            omar.Join();
            Console.WriteLine("Omar a fini...");
            fred.Interrupt();
            Console.WriteLine("Fred a fini...");
            Console.ReadLine();
        }

        static void JobToDo(Object pause) {
            try {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine("Exécution n°{0} de {1}", i, Thread.CurrentThread.Name);
                    Thread.Sleep((int)pause);
                }
            } catch (ThreadInterruptedException) {
                Console.WriteLine("Omar m'a tuer...");
            }
        }
    }
}
