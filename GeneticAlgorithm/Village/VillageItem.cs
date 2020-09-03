using InitialStrategy.Village.Abstract;
using InitialStrategy.Village.ResourceFields;
using InitialStrategy.Village.VillageFields;
using System;
using System.Collections.Generic;
using System.Data;
using static InitialStrategy.Village.Additional.UpgradeItem;

namespace InitialStrategy.Village
{
    public class VillageItem
    {
        public List<Building> buildings = new List<Building>();
        public List<int> buildingIds = new List<int>();
        public Warehouse warehouse;
        public Granary granary;


        public const int MAX_ITERATIONS = 118;

        public Random rnd = new Random();

        public VillageItem()
        {
            initWood();
            initClay();
            initIron();
            initCrop();
            initVillageBuildings();

            warehouse = buildings.Find(item => item is Warehouse) as Warehouse;
            granary = buildings.Find(item => item is Granary) as Granary;
        }

        private void initWood()
        {
            buildings.Add(new Wood(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Wood(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Wood(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Wood(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);
        }

        private void initClay()
        {
            buildings.Add(new Clay(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Clay(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Clay(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Clay(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);
        }

        private void initIron()
        {
            buildings.Add(new Iron(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Iron(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Iron(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Iron(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);
        }

        private void initCrop()
        {
            buildings.Add(new Crop(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Crop(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Crop(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Crop(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Crop(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Crop(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);
        }

        private void initVillageBuildings()
        {
            buildings.Add(new Warehouse(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Granary(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);

            buildings.Add(new Residence(buildingIds.Count + 1));
            buildingIds.Add(buildingIds.Count + 1);
        }

        public int[] getBaseGen()
        {
            List<int> newGen = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                var tt = rnd.Next(buildingIds.Count - 1);
                int newBuildingId = buildingIds[tt];

                 var newBuild = buildings.Find( item => item.id == newBuildingId);

                 if(newBuild.currentLvl + 1 <= newBuild.maxLvl)
                 {
                     var resourceTable = newBuild.upgradeTabel[newBuild.currentLvl]; // id starts from 0;

                     int isEnoughWarehouseGranary = this.isEnoughWarehouseGranary(resourceTable.resources);

                     if (isEnoughWarehouseGranary == 1)
                     {
                         setEnoughRes(resourceTable.resources);
                         newBuild.currentLvl += 1;
                         build(newBuild);
                         newGen.Add(newBuildingId);

                     } else
                     {
                         if(isEnoughWarehouseGranary == -1)
                         {
                             //warehouse;

                         }

                         if (isEnoughWarehouseGranary == -2)
                         {

                         }

                     }                       
                 }
            }

            return newGen.ToArray();
        }

        private void updateWarehouseGranary(int time)
        {
            var res = resPerHours();

            warehouse.CurrentWood += (int)Math.Round(getResPerSecond(res[0]) * time, 0) + 1;
            warehouse.CurrentClay += (int)Math.Round(getResPerSecond(res[1]) * time, 0) + 1;
            warehouse.CurrentIron += (int)Math.Round(getResPerSecond(res[2]) * time, 0) + 1;
            granary.CurrentCrop += (int)Math.Round(getResPerSecond(res[3]) * time, 0) + 1;

        }

        private double getResPerSecond(int perHour)
        {
            return perHour / 3600.0;
        }

        private void setEnoughRes(Resources res)
        {
            while (true) {
                bool isRes = warehouse.CurrentWood >= res.Wood &&
                    warehouse.CurrentClay >= res.Clay &&
                    warehouse.CurrentIron >= res.Iron &&
                    granary.CurrentCrop >= res.Crop;

                if (isRes) return;

                var resPerHour = resPerHours();

                if(!(warehouse.CurrentWood >= res.Wood))
                {
                    int needWood = res.Wood - warehouse.CurrentWood;
                    int waitTime = (int)Math.Round(3600.0 * needWood / resPerHour[0], 0) + 1;
                    updateWarehouseGranary(waitTime);
                    continue;
                }

                if (!(warehouse.CurrentClay >= res.Clay))
                {
                    int needClay = res.Clay - warehouse.CurrentClay;
                    int waitTime = (int)Math.Round(3600.0 * needClay / resPerHour[1], 1) + 1;
                    updateWarehouseGranary(waitTime);
                    continue;
                }

                if (!(warehouse.CurrentIron >= res.Iron))
                {
                    int needIron = res.Iron - warehouse.CurrentIron;
                    int waitTime = (int)Math.Round(3600.0 * needIron / resPerHour[2], 1) + 1;
                    updateWarehouseGranary(waitTime);
                    continue;
                }

                if (!(granary.CurrentCrop >= res.Crop))
                {
                    int needCrop = res.Crop - granary.CurrentCrop;
                    int waitTime = (int)Math.Round(3600.0 * needCrop / resPerHour[3], 1) + 1;
                    updateWarehouseGranary(waitTime);
                    continue;
                }
            }


        }

        private int isEnoughWarehouseGranary(Resources res)
        {
            bool isWarehouse = warehouse.getWarehouseCapacity() >= res.Wood &&
              warehouse.getWarehouseCapacity() >= res.Clay &&
              warehouse.getWarehouseCapacity() >= res.Iron;

            bool isGranary = granary.getGranaryCapacity() >= res.Crop;

            if (!isWarehouse) return -1;
            if (!isGranary) return -2;

            return 1;
        }

        private void build(Building item)
        {
            warehouse.CurrentWood -= item.upgradeTabel[item.currentLvl - 1].resources.Wood;
            warehouse.CurrentClay -= item.upgradeTabel[item.currentLvl - 1].resources.Clay;
            warehouse.CurrentIron -= item.upgradeTabel[item.currentLvl - 1].resources.Iron;
            granary.CurrentCrop -= item.upgradeTabel[item.currentLvl - 1].resources.Crop;

            updateWarehouseGranary(item.upgradeTabel[item.currentLvl - 1].time);
        }

        private int[] resPerHours()
        {
            var wood = buildings.FindAll(item => item is ResourceField && (item as ResourceField).type == Enums.ResFieldType.Wood);
            var clay = buildings.FindAll(item => item is ResourceField && (item as ResourceField).type == Enums.ResFieldType.Clay);
            var iron = buildings.FindAll(item => item is ResourceField && (item as ResourceField).type == Enums.ResFieldType.Iron);
            var crop = buildings.FindAll(item => item is ResourceField && (item as ResourceField).type == Enums.ResFieldType.Crop);

            int woodPerHour = 0;
            int clayPerHour = 0;
            int ironPerHour = 0;
            int cropPerHour = 0;

            wood.ForEach(item => woodPerHour += (item as ResourceField).getProduction());
            clay.ForEach(item => clayPerHour += (item as ResourceField).getProduction());
            iron.ForEach(item => ironPerHour += (item as ResourceField).getProduction());
            crop.ForEach(item => cropPerHour += (item as ResourceField).getProduction());

            return new int[4] { woodPerHour, clayPerHour, ironPerHour, cropPerHour };
        }


    }
}
