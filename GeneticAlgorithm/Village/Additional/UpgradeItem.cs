using System;
using InitialStrategy.Enums;

namespace InitialStrategy.Village.Additional {
    public class UpgradeItem {
        public readonly int Lvl;
        public readonly Resources ResourceTable;
        public readonly int Time;

        public UpgradeItem(int lvl, int time, int[] resources) {
            Lvl = lvl;
            Time = time;
            ResourceTable = new Resources(resources);
        }

        public int GetResourceByType(ResourceType type) {
            switch (type) {
                case ResourceType.Wood:
                    return ResourceTable.Wood;
                case ResourceType.Clay:
                    return ResourceTable.Clay;
                case ResourceType.Iron:
                    return ResourceTable.Iron;
                case ResourceType.Crop:
                    return ResourceTable.Crop;
                default: throw new Exception("Cannot get resource of this type");
            }
        }

        public readonly struct Resources {
            public readonly int Wood;
            public readonly int Clay;
            public readonly int Iron;
            public readonly int Crop;

            public Resources(int[] resources) {
                Wood = resources[0];
                Clay = resources[1];
                Iron = resources[2];
                Crop = resources[3];
            }
        }
    }
}
