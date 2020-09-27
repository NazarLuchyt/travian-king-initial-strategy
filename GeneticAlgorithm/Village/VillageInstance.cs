using System;
using System.Collections.Generic;
using System.Linq;
using InitialStrategy.Enums;
using InitialStrategy.Village.Abstract;
using InitialStrategy.Village.ResourceFields;
using InitialStrategy.Village.VillageFields;

namespace InitialStrategy.Village {
    public class VillageInstance {
        private const int ExceptionalResultValue = 1000000;

        private readonly Random _rnd = new Random();
        //public const int MAX_ITERATIONS = 118;

        public List<int> BuildingIds = new List<int>();
        public List<Building> Buildings = new List<Building>();
        public Granary Granary;
        public Residence Residence;
        public Warehouse Warehouse;

        public VillageInstance() {
            InitVillage();

            Warehouse = Buildings.Find(item => item is Warehouse) as Warehouse;
            Granary = Buildings.Find(item => item is Granary) as Granary;
            Residence = Buildings.Find(item => item is Residence) as Residence;
        }

        public int GetMaxBuildingId() {
            return BuildingIds.Count;
        }

        public int GetEvaluate(int[] genes) {
            RefreshState();
            var result = 0;

            foreach (var idToBuild in genes) {
                var buildToBuild = Buildings.Find(item => item.Id == idToBuild);

                if (buildToBuild == null) {
                    Console.WriteLine($"Building with id {idToBuild} wasn't find");
                    result += ExceptionalResultValue;
                    break;
                }

                if (!buildToBuild.IsPossibleToBuild()) {
                    Console.WriteLine(
                        $"Try to build to impossible lvl {buildToBuild.GetName()}. Current lvl {buildToBuild.CurrentLvl} | Max lvl {buildToBuild.MaxLvl}");
                    result += ExceptionalResultValue;
                    break;
                }

                if (!IsEnoughCapacity(buildToBuild.GetNextRequireResources())) {
                    Console.WriteLine(
                        $"Not ENOUGH capacity for {buildToBuild.GetName()}. Current lvl {buildToBuild.CurrentLvl}");
                    result += ExceptionalResultValue;
                    break;
                }

                result += GetSpentTimeForUpgradeBuilding(buildToBuild);
            }


            if (Residence.CurrentLvl != Residence.MaxLvl) {
                result += ExceptionalResultValue;
            } else {
                Console.WriteLine("First success");
            }

            return result;
        }

        //public int[] getBaseGen() {
        //    var newGen = new List<int>();

        //    for (var i = 0; i < 20; i++) {
        //        var tt = rnd.Next(BuildingIds.Count - 1);
        //        var newBuildingId = BuildingIds[tt];

        //        var newBuild = Buildings.Find(item => item.Id == newBuildingId);

        //        if (newBuild.CurrentLvl + 1 <= newBuild.MaxLvl) {
        //            var resourceTable = newBuild.UpgradeTable[newBuild.CurrentLvl]; // Id starts from 0;

        //            var isEnoughWarehouseGranary = this.isEnoughWarehouseGranary(resourceTable.ResourceTable);

        //            if (isEnoughWarehouseGranary == 1) {
        //                setEnoughRes(resourceTable.ResourceTable);
        //                newBuild.CurrentLvl += 1;
        //                build(newBuild);
        //                newGen.Add(newBuildingId);
        //            } else {
        //                if (isEnoughWarehouseGranary == -1) {
        //                    //warehouse;
        //                }

        //                if (isEnoughWarehouseGranary == -2) { }
        //            }
        //        }
        //    }

        //    return newGen.ToArray();
        //}

        private void RefreshState() {
            Buildings.ForEach(item => item.RefreshState());
        }

        private int GetSpentTimeForUpgradeBuilding(Building building) {
            var resources = building.GetNextRequireResources();
            var waitResourceTime = GetTimeToWaitResources(building);

            UpdateWarehouseGranary(waitResourceTime);

            if (GetTimeToWaitResources(building) != 0) Console.WriteLine("UpdateWarehouseGranary works incorrect");

            UpdateWarehouseGranaryAfterBuilding(resources);

            var timeToBuild = building.GetNextRequireTime();
            UpdateWarehouseGranary(timeToBuild);

            building.UpgradeLvl();
            return waitResourceTime + timeToBuild;
        }

        private void UpdateWarehouseGranary(int time) {
            var production = GetProductionPerSecond();

            if (time == 0) return;

            Warehouse.CurrentWood += (int) Math.Round(production[0] * time, 0);
            Warehouse.CurrentClay += (int) Math.Round(production[1] * time, 0);
            Warehouse.CurrentIron += (int) Math.Round(production[2] * time, 0);
            Granary.CurrentCrop += (int) Math.Round(production[3] * time, 0);
        }

        private void UpdateWarehouseGranaryAfterBuilding(int[] resourcesToSpend) {
            Warehouse.CurrentWood -= resourcesToSpend[0];
            Warehouse.CurrentClay -= resourcesToSpend[1];
            Warehouse.CurrentIron -= resourcesToSpend[2];
            Granary.CurrentCrop -= resourcesToSpend[3];
        }

        private bool IsEnoughCapacity(int[] needResources) {
            var warehouseCapacity = Warehouse.GetCapacity();
            var granaryCapacity = Granary.GetCapacity();

            var needWood = needResources[0];
            var needClay = needResources[1];
            var needIron = needResources[2];
            var needCrop = needResources[3];


            var isEnoughWarehouseCapacity = warehouseCapacity >= needWood &&
                                            warehouseCapacity >= needClay &&
                                            warehouseCapacity >= needIron;

            var isEnoughGranaryCapacity = granaryCapacity >= needCrop;

            return isEnoughWarehouseCapacity && isEnoughGranaryCapacity;
        }

        private int GetTimeToWaitResources(Building building) {
            var needResources = building.GetNextRequireResources();
            var production = GetProductionPerSecond();

            var needWood = needResources[0];
            var needClay = needResources[1];
            var needIron = needResources[2];
            var needCrop = needResources[3];

            //var needWood = 1458;
            //var needClay = 1109;
            //var needIron = 1347;
            //var needCrop = 1698;

            var needToWaitTime = new List<int>();

            if (!(Warehouse.CurrentWood >= needWood)) {
                var needProduce = needWood - Warehouse.CurrentWood;
                needToWaitTime.Add((int) Math.Round(needProduce / production[0], 0));
            }

            if (!(Warehouse.CurrentClay >= needClay)) {
                var needProduce = needClay - Warehouse.CurrentClay;
                needToWaitTime.Add((int) Math.Round(needProduce / production[1], 0));
            }

            if (!(Warehouse.CurrentIron >= needIron)) {
                var needProduce = needIron - Warehouse.CurrentIron;
                needToWaitTime.Add((int) Math.Round(needProduce / production[2], 0));
            }

            if (!(Granary.CurrentCrop >= needCrop)) {
                var needProduce = needCrop - Granary.CurrentCrop;
                needToWaitTime.Add((int) Math.Round(needProduce / production[3], 0));
            }

            return needToWaitTime.Count > 0 ? needToWaitTime.Max() : 0;
        }

        private void build(Building item) {
            //Warehouse.CurrentWood -= item.UpgradeTable[item.CurrentLvl - 1].ResourceTable.Wood;
            //Warehouse.CurrentClay -= item.UpgradeTable[item.CurrentLvl - 1].ResourceTable.Clay;
            //Warehouse.CurrentIron -= item.UpgradeTable[item.CurrentLvl - 1].ResourceTable.Iron;
            //Granary.CurrentCrop -= item.UpgradeTable[item.CurrentLvl - 1].ResourceTable.Crop;


            //updateWarehouseGranary(item.UpgradeTable[item.CurrentLvl - 1].Time);
        }

        private double[] GetProductionPerSecond() {
            var wood = Buildings.FindAll(item =>
                item is ResourceField field && field.Type == ResourceType.Wood);

            var clay = Buildings.FindAll(item =>
                item is ResourceField field && field.Type == ResourceType.Clay);

            var iron = Buildings.FindAll(item =>
                item is ResourceField field && field.Type == ResourceType.Iron);

            var crop = Buildings.FindAll(item =>
                item is ResourceField field && field.Type == ResourceType.Crop);

            var woodPerHour = 0;
            var clayPerHour = 0;
            var ironPerHour = 0;
            var cropPerHour = 0;


            wood.ForEach(item => woodPerHour += ((ResourceField) item).GetProduction());
            clay.ForEach(item => clayPerHour += ((ResourceField) item).GetProduction());
            iron.ForEach(item => ironPerHour += ((ResourceField) item).GetProduction());
            crop.ForEach(item => cropPerHour += ((ResourceField) item).GetProduction());

            return new[] {
                woodPerHour / 3600.0,
                clayPerHour / 3600.0,
                ironPerHour / 3600.0,
                cropPerHour / 3600.0
            };
        }

        #region initMethods

        private void InitVillage() {
            InitWood();
            InitClay();
            InitIron();
            InitCrop();
            InitVillageBuildings();
        }

        private void InitWood() {
            Buildings.Add(new Wood(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Wood(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Wood(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Wood(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);
        }

        private void InitClay() {
            Buildings.Add(new Clay(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Clay(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Clay(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Clay(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);
        }

        private void InitIron() {
            Buildings.Add(new Iron(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Iron(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Iron(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Iron(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);
        }

        private void InitCrop() {
            Buildings.Add(new Crop(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Crop(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Crop(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Crop(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Crop(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Crop(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);
        }

        private void InitVillageBuildings() {
            Buildings.Add(new Warehouse(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Granary(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);

            Buildings.Add(new Residence(BuildingIds.Count + 1));
            BuildingIds.Add(BuildingIds.Count + 1);
        }

        #endregion
    }
}
