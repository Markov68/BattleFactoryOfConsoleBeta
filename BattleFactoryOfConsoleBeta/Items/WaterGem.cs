using System.Diagnostics.Metrics;
using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class WaterGem: Item
    {
        public WaterGem() : base("みずのジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Water;
            }
        }

    }
}
