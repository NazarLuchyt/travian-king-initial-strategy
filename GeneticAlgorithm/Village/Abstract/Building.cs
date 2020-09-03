using InitialStrategy.Village.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialStrategy.Village.Abstract
{
    public abstract class Building
    {
        public readonly int id;
        public UpgradeItem[] upgradeTabel;
        public readonly int maxLvl;
        public int currentLvl = 0;
        public int serverSpeed = 3;

        public Building(int id, int maxLvl)
        {
            this.id = id;
            this.maxLvl = maxLvl;
        }

        public abstract void InitResTable();
    }
}

// 116
