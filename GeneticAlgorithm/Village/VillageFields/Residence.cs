using InitialStrategy.Village.Abstract;
using InitialStrategy.Village.Additional;

namespace InitialStrategy.Village.VillageFields {
    public class Residence : Building {
        private static readonly UpgradeItem[] InitResourceTable = {
            new UpgradeItem(1, 670, new int[4] {580, 460, 350, 180}),
            new UpgradeItem(2, 870, new int[4] {740, 590, 450, 230}),
            new UpgradeItem(3, 1110, new int[4] {950, 755, 575, 295}),
            new UpgradeItem(4, 1390, new int[4] {1215, 965, 735, 375}),
            new UpgradeItem(5, 1710, new int[4] {1555, 1235, 940, 458}),
            new UpgradeItem(6, 2090, new int[4] {1995, 1580, 1205, 620}),
            new UpgradeItem(7, 2520, new int[4] {2550, 2025, 1540, 790}),
            new UpgradeItem(8, 3030, new int[4] {3265, 2590, 1970, 1015}),
            new UpgradeItem(9, 3030, new int[4] {4180, 3315, 2520, 1295}),
            new UpgradeItem(10, 3030, new int[4] {5350, 4245, 3230, 1660})
        };

        public Residence(int id, int maxLvl = 10) : base(id, maxLvl, InitResourceTable) { }

        public override string Name { get; set; } = "Residence";

        public override string GetName() {
            return $"Residence[{Id}]";
        }
    }
}
