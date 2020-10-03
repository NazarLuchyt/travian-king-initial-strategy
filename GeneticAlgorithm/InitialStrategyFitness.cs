using System;
using System.Linq;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Fitnesses;
using InitialStrategy.Village;

namespace InitialStrategy {
    public class InitialStrategyFitness : IFitness {
        private readonly VillageInstance _village;

        public InitialStrategyFitness(VillageInstance village) {
            _village = village;
        }

        public double EvaluateOld(IChromosome chromosome) {
            // Evaluate the fitness of chromosome.
            var genes = chromosome.GetGenes().ToList();


            var result = _village.GetEvaluate(genes.ConvertAll(item => (int)item.Value).ToArray());
            ((InitialStrategyChromosome) chromosome).TimeValue = result;
            return Math.Pow(result + 1, -1) + 0.1;
        }

        public double Evaluate(IChromosome chromosome) {
            // Evaluate the fitness of chromosome.
            var genes = chromosome.GetGenes().ToList();


            var result = _village.GetEvaluate(genes.ConvertAll(item => (int)item.Value).ToArray());
            ((InitialStrategyChromosome)chromosome).TimeValue = result;
            return -1 * result;
        }

    }
}
