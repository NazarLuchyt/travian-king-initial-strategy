using InitialStrategy.Enums;
using InitialStrategy.Village.Abstract;
using InitialStrategy.Village.Additional;

namespace InitialStrategy.Village.ResourceFields {
    public class Wood : ResourceField {
        private static readonly UpgradeItem[] InitResourceTable = {
            new UpgradeItem(1, 90, new int[4] {40, 100, 50, 60}),
            new UpgradeItem(2, 210, new int[4] {65, 165, 85, 100}),
            new UpgradeItem(3, 400, new int[4] {110, 280, 140, 165}),
            new UpgradeItem(4, 700, new int[4] {185, 465, 235, 280}),
            new UpgradeItem(5, 1190, new int[4] {310, 780, 390, 465})
        };

        public Wood(int id, int maxLvl = 5) : base(id, maxLvl, ResourceType.Wood, InitResourceTable) { }
        public override string Name { get; set; } = "Wood";

        public override string GetName() {
            return $"Wood[{Id}]";
        }
    }
}
