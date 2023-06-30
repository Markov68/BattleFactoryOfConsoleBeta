using BattleOfConsole.Abilities;
using System.Diagnostics;
using static BattleOfConsole.Skill;

namespace BattleOfConsole.Items
{
    internal class PixiePlate:Item
    {
        public PixiePlate() : base("せいれいプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Fairy;
            }
        }
    }
}
