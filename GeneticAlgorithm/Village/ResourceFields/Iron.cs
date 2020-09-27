using InitialStrategy.Enums;
using InitialStrategy.Village.Abstract;
using InitialStrategy.Village.Additional;

namespace InitialStrategy.Village.ResourceFields {
    public class Iron : ResourceField {
        private static readonly UpgradeItem[] InitResourceTable = {
            new UpgradeItem(1, 150, new int[4] {100, 80, 30, 60}),
            new UpgradeItem(2, 310, new int[4] {165, 135, 50, 100}),
            new UpgradeItem(3, 560, new int[4] {280, 225, 85, 165}),
            new UpgradeItem(4, 960, new int[4] {465, 375, 140, 280}),
            new UpgradeItem(5, 1600, new int[4] {780, 630, 235, 465})
        };

        public Iron(int id, int maxLvl = 5) : base(id, maxLvl, ResourceType.Iron, InitResourceTable) { }

        public override string GetName() {
            return $"Iron[{Id}]";
        }
    }
}
