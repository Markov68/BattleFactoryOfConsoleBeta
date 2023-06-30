using BattleOfConsole.Skills;
using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class GhostGem:Item
    {
        public GhostGem() : base("ゴーストジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Gohst;
            }
        }

    }
}
