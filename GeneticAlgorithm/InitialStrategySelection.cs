using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Selections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialStrategy
{
    class InitialStrategySelection : SelectionBase
    {
        public InitialStrategySelection(): base(5)
        {

        }

        protected override IList<IChromosome> PerformSelectChromosomes(int number, Generation generation)
        {
            var ordered = generation.Chromosomes.OrderBy(c => c.Fitness);
            
            return ordered.Take(number).ToList();
        }
    }
}
