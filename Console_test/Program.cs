using System;
using InitialStrategy;
using InitialStrategy.Village;

namespace Console_test {
    internal class Program {
        private static void Main(string[] args) {
            var test1 = new VillageInstance();

            var test = new InitialStrategyDomain();
            test.Run();
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
