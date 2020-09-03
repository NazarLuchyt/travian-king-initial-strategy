using InitialStrategy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialStrategy.Village.Abstract
{
    public abstract class ResourceField : Building
    {
        public readonly ResFieldType type;
        private readonly int[] productionTable = {
            7,
            13,
            21,
            31,
            46,
            70,
            98,
            140,
            203,
            280
        };

        public ResourceField(int id, int maxLvl, ResFieldType type) : base(id, maxLvl)
        {
            this.type = type;
            currentLvl = 1;
        }

        public int getProduction()
        {
            return productionTable[currentLvl - 1];

        }
    }
}
