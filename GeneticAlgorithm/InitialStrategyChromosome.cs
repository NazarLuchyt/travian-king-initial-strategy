using GeneticSharp.Domain.Chromosomes;
using InitialStrategy.Village;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialStrategy
{
    class InitialStrategyChromosome : ChromosomeBase
    {
        // Change the argument value passed to base constructor to change the length 
        // of your chromosome.
        private readonly VillageItem village;

        public InitialStrategyChromosome() : base(20)
        {
            CreateGenes();
            
        }

        public override Gene GenerateGene(int geneIndex)
        {
            var village = new VillageItem();
            var result = village.getBaseGen();
            // Generate a gene base on my problem chromosome representation.
            return new Gene(village);
        }

        public override IChromosome CreateNew()
        {
            return new InitialStrategyChromosome();
        }
    }
}
