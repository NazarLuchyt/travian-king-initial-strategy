using System;
using System.Collections.Generic;
using System.Linq;
using GeneticSharp.Domain.Chromosomes;

namespace InitialStrategy {
    internal class InitialStrategyChromosome : ChromosomeBase {
        private readonly int _goalId;
        private readonly int _maxBuildingId;

        // Change the argument value passed to base constructor to change the length 
        // of your chromosome.
        private readonly Random _rnd = new Random(Guid.NewGuid().GetHashCode());

        public int TimeValue;

        // 118
        public InitialStrategyChromosome(int maxBuildingId, int goalId) : base(116) {
            _maxBuildingId = maxBuildingId;
            _goalId = goalId;
            CreateGenes();
            //var test = GetGenes();

            //Console.WriteLine("Genes ->");
            //foreach (Gene gene in test) {
            //    Console.Write("Genes -> {0}", gene.Value);
            //}
        }

        public override Gene GenerateGene(int geneIndex) {
            // Generate a gene base on my problem chromosome representation.
            var test = new List<int>();

            for (var i = 0; i < 116; i++) {
                var newGen = _rnd.Next(1, _maxBuildingId + 3);
                if (newGen > _maxBuildingId) {
                    newGen = _goalId;
                }

                test.Add(newGen);
            }

            var result = test.Count(item => item == _goalId);
            var result2 = test.Count(item => item > _maxBuildingId);

            if (result2 > 0) {
                Console.WriteLine("ERRORORORORORORO");
            }


            return new Gene(CreateGen());
        }

        public override IChromosome CreateNew() {
            return new InitialStrategyChromosome(_maxBuildingId, _goalId);
        }

        public string GetHumanTime() {
            var humanTime = TimeSpan.FromSeconds(TimeValue);

            //here backslash is must to tell that colon is
            //not the part of format, it just a character that we want in output
            var str = humanTime.ToString(@"hh\:mm\:ss");
            return $"{humanTime.Days} day(s) {str}";
        }

        private int CreateGen() {
            var newGen = _rnd.Next(1, _maxBuildingId + 3);
            if (newGen > _maxBuildingId) {
                newGen = _goalId;
            }

            return newGen;
        }
    }
}
