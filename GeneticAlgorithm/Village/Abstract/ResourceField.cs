using System.Collections.Generic;
using InitialStrategy.Enums;
using InitialStrategy.Village.Additional;

namespace InitialStrategy.Village.Abstract {
    public abstract class ResourceField : Building {
        private readonly int[] _productionTable = {
            3,
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

        public readonly ResourceType Type;

        protected ResourceField(int id, int maxLvl, ResourceType type, IEnumerable<UpgradeItem> upgradeTable) : base(id,
            maxLvl, upgradeTable) {
            Type = type;
        }

        public int GetProduction() {
            return _productionTable[CurrentLvl] * ServerSpeed;
        }
    }
}
