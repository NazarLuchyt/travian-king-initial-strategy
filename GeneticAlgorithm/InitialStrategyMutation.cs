using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Infrastructure.Framework.Commons;

namespace InitialStrategy {
    public class InitialStrategyMutation : MutationBase {
        public InitialStrategyMutation() {
            var test = 10;
        }

        public new void Mutate(IChromosome chromosome, float probability) {
            ExceptionHelper.ThrowIfNull("chromosome", chromosome);

            PerformMutate(chromosome, probability);
        }

        protected override void PerformMutate(IChromosome chromosome, float probability) {


            var test = 10;
        }
    }
}
