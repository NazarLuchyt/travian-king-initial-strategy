using InitialStrategy.Village.Abstract;
using InitialStrategy.Village.Additional;

namespace InitialStrategy.Village.VillageFields
{
    public class Granary : Building
    {

        const int MAX_LVL = 8;
        private int currentCrop;

        public int CurrentCrop
        {
            get
            {
                return currentCrop;

            }
            set
            {
                currentCrop = value;
                if (value > getGranaryCapacity()) currentCrop = getGranaryCapacity();

            }
        }

        private readonly int[] Capacity = new int[] {
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
        public Granary(int id, int maxLvl = MAX_LVL) : base(id, maxLvl)
        {
            InitResTable();
            CurrentCrop = 800;
        }

        public override void InitResTable()
        {
            upgradeTabel = new UpgradeItem[MAX_LVL]
            {
               new UpgradeItem(1, 670, new int[4] { 70, 90, 70, 20 }),
               new UpgradeItem(2, 870, new int[4] { 115, 150, 115, 35 }),
               new UpgradeItem(3, 1110, new int[4] { 195, 250, 195, 55 }),
               new UpgradeItem(4, 1390, new int[4] { 325, 420, 325, 95 }),
               new UpgradeItem(5, 1710, new int[4] { 545, 700, 545, 155 }),
               new UpgradeItem(6, 2090, new int[4] { 545, 700, 545, 155 }),
               new UpgradeItem(7, 2520, new int[4] { 545, 700, 545, 155 }),
               new UpgradeItem(8, 3030, new int[4] { 545, 700, 545, 155 }),
            };
        }

        public int getGranaryCapacity()
        {
            return Capacity[currentLvl];
        }
    }
}
