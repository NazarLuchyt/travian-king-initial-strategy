using InitialStrategy.Village.Abstract;
using InitialStrategy.Village.Additional;

namespace InitialStrategy.Village.VillageFields {
    public class Granary : Building, IResourceSafePlace {
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

        private int _currentCrop;

        public Granary(int id, int maxLvl = 8, int initialValue = 800) : base(id, maxLvl, InitResourceTable) {
            CurrentCrop = _initialResourceValue = initialValue;
        }

        public override string Name { get; set; } = "Granary";

        public int CurrentCrop {
            get => _currentCrop;
            set {
                _currentCrop = value;
                if (value > GetCapacity()) {
                    _currentCrop = GetCapacity();
                }
            }
        }

        public void RefreshResourceState() {
            CurrentCrop = _initialResourceValue;
        }

        public int GetCapacity() {
            return _capacity[CurrentLvl];
        }

        public override void RefreshState() {
            base.RefreshState();
            RefreshResourceState();
        }

        public override string GetName() {
            return $"Granary[{Id}]";
        }
    }
}
