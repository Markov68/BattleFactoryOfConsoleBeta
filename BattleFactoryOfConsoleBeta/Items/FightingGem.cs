using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class FightingGem:Item
    {
        public FightingGem() : base("かくとうジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Fight;
            }
        }

    }
}
