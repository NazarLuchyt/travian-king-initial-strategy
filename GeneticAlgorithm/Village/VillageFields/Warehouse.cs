using InitialStrategy.Village.Abstract;
using InitialStrategy.Village.Additional;

namespace InitialStrategy.Village.VillageFields {
    public class Warehouse : Building, IResourceSafePlace {
        private static readonly UpgradeItem[] InitResourceTable = {
            new UpgradeItem(1, 670, new int[4] {70, 90, 70, 20}),
            new UpgradeItem(2, 870, new int[4] {115, 150, 115, 35}),
            new UpgradeItem(3, 1110, new int[4] {195, 250, 195, 55}),
            new UpgradeItem(4, 1390, new int[4] {325, 420, 325, 95}),
            new UpgradeItem(5, 1710, new int[4] {545, 700, 545, 155}),
            new UpgradeItem(6, 2090, new int[4] {545, 700, 545, 155}),
            new UpgradeItem(7, 2520, new int[4] {545, 700, 545, 155}),
            new UpgradeItem(8, 3030, new int[4] {545, 700, 545, 155})
        };

        private readonly int[] _capacity = {
            800,
            1200,
            1700,
            2300,
            3100,
            4000,
            5000,
            6300,
            7800
        };

        private readonly int _initialResourceValue;

        private int _currentClay;
        private int _currentIron;

        private int _currentWood;

        public Warehouse(int id, int maxLvl = 8, int initialValue = 800) : base(id, maxLvl, InitResourceTable) {
            CurrentWood = CurrentClay = CurrentIron = _initialResourceValue = initialValue;
        }

        public override string Name { get; set; } = "Warehouse";

        public int CurrentWood {
            get => _currentWood;
            set {
                _currentWood = value;
                if (value > GetCapacity()) {
                    _currentWood = GetCapacity();
                }
            }
        }

        public int CurrentClay {
            get => _currentClay;
            set {
                _currentClay = value;
                if (value > GetCapacity()) {
                    _currentClay = GetCapacity();
                }
            }
        }

        public int CurrentIron {
            get => _currentIron;
            set {
                _currentIron = value;
                if (value > GetCapacity()) {
                    _currentIron = GetCapacity();
                }
            }
        }

        public void RefreshResourceState() {
            CurrentWood = CurrentClay = CurrentIron = _initialResourceValue;
        }

        public int GetCapacity() {
            return _capacity[CurrentLvl];
        }

        public override void RefreshState() {
            base.RefreshState();
            RefreshResourceState();
        }

        public override string GetName() {
            return $"Warehouse[{Id}]";
        }
    }
}
