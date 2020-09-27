using System;
using GeneticSharp.Domain.Chromosomes;

namespace InitialStrategy {
    internal class InitialStrategyChromosome : ChromosomeBase {
        // Change the argument value passed to base constructor to change the length 
        // of your chromosome.
        private readonly Random _rnd = new Random(Guid.NewGuid().GetHashCode());
        private readonly int _maxBuildingId;
        public int TimeValue;
        // 118
        public InitialStrategyChromosome(int maxBuildingId) : base(118) {
            _maxBuildingId = maxBuildingId;
            CreateGenes();
            //var test = GetGenes();

            //Console.WriteLine("Genes ->");
            //foreach (Gene gene in test) {
            //    Console.Write("Genes -> {0}", gene.Value);
            //}
           
        }

        public override Gene GenerateGene(int geneIndex) {
            //var village = new VillageInstance();
            //var result = village.getBaseGen();
            // Generate a gene base on my problem chromosome representation.

            return new Gene(_rnd.Next(1, _maxBuildingId));
        }

        public override IChromosome CreateNew() {
            return new InitialStrategyChromosome(_maxBuildingId);
        }
    }
}
