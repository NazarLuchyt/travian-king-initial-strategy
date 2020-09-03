using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialStrategy;
using InitialStrategy.Village;
using InitialStrategy.Village.ResourceFields;

namespace Console_test
{
    class Program
    {
        static void Main(string[] args)
        {

            var test1 = new VillageItem();

            var test = new InitialStrategyDomain();
            test.Run();
        }
    }
}
