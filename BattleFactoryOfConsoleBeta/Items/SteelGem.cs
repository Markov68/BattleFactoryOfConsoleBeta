using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class SteelGem:Item
    {
        public SteelGem() : base("はがねのジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Metal;
            }
        }

    }
}
