using System;
using System.Collections.Generic;
using System.Linq;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Selections;

namespace InitialStrategy {
    internal class InitialStrategySelection : SelectionBase {
        private readonly InitialStrategyDomain.GenerationStats _del;

        public InitialStrategySelection(InitialStrategyDomain.GenerationStats del) : base(5) {
            _del = del;
        }

        protected override IList<IChromosome> PerformSelectChromosomes(int number, Generation generation) {
            var ordered = generation.Chromosomes.OrderByDescending(c => c.Fitness);

            var averageValue = generation.Chromosomes.Average(item => item.Fitness);

            if (averageValue != null && generation.BestChromosome.Fitness != null) {
                _del(generation.Number, -1 * (int) Math.Round((double) averageValue, 0),
                    -1 * (int) generation.BestChromosome.Fitness);
            }

            return ordered.Take(number).ToList();
        }
    }
}
