using System;
using System.Linq;
using GeneticSharp.Domain;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Terminations;
using InitialStrategy.Village;
using InitialStrategy.Village.Additional;

namespace InitialStrategy {
    public class InitialStrategyDomain {
        public delegate void FinishStats(ResultItem result);

        public delegate void GenerationStats(int generationNumber, int averageValue, int bestValue);

        public void Run(GenerationStats test, FinishStats finishStats) {
            var village = new VillageInstance();
            var selection = new InitialStrategySelection(test);


            //var crossover = new CutAndSpliceCrossover();
            var crossover = new UniformCrossover(0.5f);
            //var crossover = new CycleCrossover();


            //var mutation = new ReverseSequenceMutation();
            //var mutation = new UniformMutation(true);
            var mutation = new InitialStrategyMutation();


            var fitness = new InitialStrategyFitness(village);
            var chromosome = new InitialStrategyChromosome(village.GetMaxBuildingId(), village.GetResidenceId());

            var population = new Population(50, 200, chromosome);

            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new FitnessStagnationTermination(100);

            Console.WriteLine("GA running...");
            ga.Start();

            var bestChromosome = (InitialStrategyChromosome) ga.BestChromosome;

            Console.WriteLine("Best solution found has {0} fitness. Generation {1}, Residence lvl {2}",
                bestChromosome.Fitness,
                ga.GenerationsNumber,
                bestChromosome.GetGenes().Count(item => (int) item.Value == village.GetResidenceId()));
            Console.WriteLine("Solution: ");
            foreach (var gene in bestChromosome.GetGenes()) {
                Console.Write("{0} |", (int) gene.Value);
            }

            if (bestChromosome.Fitness != null) {
                Console.WriteLine($"Convert to hours {bestChromosome.GetHumanTime()}");
            }

            var resultItem = new ResultItem();
            resultItem.Strategy = bestChromosome.GetGenes().Select(gene => (int) gene.Value).ToList();
            resultItem.GenerationNumber = ga.GenerationsNumber;
            resultItem.ResultHours = bestChromosome.GetHumanTime();

            finishStats(resultItem);
        }
    }
}
