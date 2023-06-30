using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class RockGem:Item
    {
        public RockGem() : base("いわのジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Rock;
            }
        }

    }
}
