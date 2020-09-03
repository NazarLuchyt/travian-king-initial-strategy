using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialStrategy.Village.Additional
{
    public class UpgradeItem
    {
        public readonly int lvl;
        public readonly int time;
        public readonly Resources resources;
        public readonly struct Resources
        {
            public readonly int Wood;
            public readonly int Clay;
            public readonly int Iron;
            public readonly int Crop;

            public Resources(int[] resources)
            {
                Wood = resources[0];
                Clay = resources[1];
                Iron = resources[2];
                Crop = resources[3];
            }
        }

        public UpgradeItem(int lvl, int time, int[] resources)
        {
            this.lvl = lvl;
            this.time = time;
            this.resources = new Resources(resources);
        }

    }
}
