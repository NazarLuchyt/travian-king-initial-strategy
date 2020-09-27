using System;
using GeneticSharp.Domain;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Selections;
using GeneticSharp.Domain.Terminations;
using InitialStrategy.Village;

namespace InitialStrategy
{
    public class InitialStrategyDomain
    {
        public void Run()
        {
            var village = new VillageInstance();
            var selection = new EliteSelection();
            //var crossover = new CutAndSpliceCrossover();
            var crossover = new UniformCrossover(0.5f);
            var mutation = new ReverseSequenceMutation();
            var fitness = new InitialStrategyFitness(village);
            var chromosome = new InitialStrategyChromosome(village.GetMaxBuildingId());


            var population = new Population(50, 150, chromosome);

            population.CreateInitialGeneration();
            var t = population.CurrentGeneration.Chromosomes[0].Fitness;

            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new FitnessStagnationTermination(300);

            Console.WriteLine("GA running...");
            ga.Start();

            Console.WriteLine("Best solution found has {0} fitness. Generation {1}", ga.BestChromosome.Fitness, ga.GenerationsNumber);
            if (ga.BestChromosome.Fitness != null) {
                TimeSpan time = TimeSpan.FromSeconds(((InitialStrategyChromosome) ga.BestChromosome).TimeValue);

                //here backslash is must to tell that colon is
                //not the part of format, it just a character that we want in output
                string str = time.ToString(@"hh\:mm\:ss\:fff");
                
                Console.WriteLine($"Convert to hours {str}");
            }

          
        }
    }
}
