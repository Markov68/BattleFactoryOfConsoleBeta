using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class PoisonGem:Item
    {
        public PoisonGem() : base("どくのジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Poison;
            }
        }

    }
}
