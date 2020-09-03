using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Fitnesses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialStrategy
{
    public class InitialStrategyFitness : IFitness
    {
        public double Evaluate(IChromosome chromosome)
        {
            // Evaluate the fitness of chromosome.
            var t = chromosome.GetGenes().ToList();
            var summ = 0;
            t.ForEach(item => summ += (int)item.Value == 3 ? 1 : 100);
            Console.WriteLine("Evaluate end -> {0}", summ);
            return summ;
        }
    }
}
