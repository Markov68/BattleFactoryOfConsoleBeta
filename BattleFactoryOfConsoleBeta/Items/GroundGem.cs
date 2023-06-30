using System.Numerics;
using System.Text.RegularExpressions;

namespace BattleOfConsole.Items
{
    internal class GroundGem:Item
    {
        public GroundGem() : base("じめんのジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Grand;
            }
        }

    }
}
