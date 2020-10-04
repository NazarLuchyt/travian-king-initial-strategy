using System;
using System.Collections.Generic;
using InitialStrategy.Enums;
using InitialStrategy.Village.Additional;

namespace InitialStrategy.Village.Abstract {
    public abstract class Building {
        private readonly int _initialLvl;
        private readonly List<UpgradeItem> _upgradeTable = new List<UpgradeItem>();
        public readonly int Id;
        public readonly int MaxLvl;
        public readonly int ServerSpeed;
        public abstract string Name { get; set; }

        protected Building(int id, int maxLvl, IEnumerable<UpgradeItem> upgradeTable, int initialLvl = 0,
            int serverSpeed = 3) {
            Id = id;
            MaxLvl = maxLvl;
            ServerSpeed = serverSpeed;
            _upgradeTable.AddRange(upgradeTable);
            CurrentLvl = _initialLvl = initialLvl;
        }

        public int CurrentLvl { get; private set; }

        public int[] GetNextRequireResources() {
            int[] result = {
                GetNextRequireResourceByType(ResourceType.Wood),
                GetNextRequireResourceByType(ResourceType.Clay),
                GetNextRequireResourceByType(ResourceType.Iron),
                GetNextRequireResourceByType(ResourceType.Crop)
            };

            return result;
        }

        public int GetNextRequireResourceByType(ResourceType type) {
            return GetRequireResourceOnLvlByType(CurrentLvl + 1, type);
        }

        public int GetRequireResourceOnLvlByType(int lvl, ResourceType type) {
            if (lvl <= 0 && lvl > MaxLvl && lvl > _upgradeTable.Count)
                throw new Exception("Try to use incorrect lvl to get require resource");

            var requireData = _upgradeTable.Find(upgradeItem => upgradeItem.Lvl == lvl);

            if (requireData == null) throw new Exception("Require lvl wasn't found");

            return requireData.GetResourceByType(type);
        }

        public int GetNextRequireTime() {
            return GetRequireTimeByLvl(CurrentLvl + 1);
        }

        public int GetRequireTimeByLvl(int lvl) {
            if (lvl <= 0 && lvl > MaxLvl && lvl > _upgradeTable.Count)
                throw new Exception("Try to use incorrect lvl to get require time to build");

            var requireData = _upgradeTable.Find(upgradeItem => upgradeItem.Lvl == lvl);

            if (requireData == null) throw new Exception("Require lvl wasn't found");

            return requireData.Time;
        }

        public void UpgradeLvl() {
            CurrentLvl += 1;
        }

        public virtual void RefreshState() {
            CurrentLvl = _initialLvl;
        }

        public bool IsPossibleToBuild() {
            return CurrentLvl + 1 <= MaxLvl;
        }

        public abstract string GetName();
    }
}
