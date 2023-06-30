using System.Diagnostics;
using static BattleOfConsole.Skill;

namespace BattleOfConsole.Items
{
    internal class DracoPlate:Item
    {
        public DracoPlate() : base("りゅうのプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Dragon;
            }
        }

    }
}
