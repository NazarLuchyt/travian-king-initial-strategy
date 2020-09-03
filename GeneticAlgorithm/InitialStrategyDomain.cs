using GeneticSharp.Domain;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Selections;
using GeneticSharp.Domain.Terminations;
using InitialStrategy.Village;
using System;

namespace InitialStrategy
{
    public class InitialStrategyDomain
    {
        public void Run()
        {
            var selection = new InitialStrategySelection();
            var crossover = new CutAndSpliceCrossover();
            var mutation = new TworsMutation();
            var fitness = new InitialStrategyFitness();
            var chromosome = new InitialStrategyChromosome();


            var population = new Population(50, 70, chromosome);

            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new FitnessStagnationTermination(20);

            Console.WriteLine("GA running...");
            ga.Start();

            Console.WriteLine("Best solution found has {0} fitness.", ga.BestChromosome.Fitness);
        }
    }
}
