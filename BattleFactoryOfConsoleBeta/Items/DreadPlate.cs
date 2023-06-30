using System.Diagnostics;
using System.Threading;
using static BattleOfConsole.Skill;

namespace BattleOfConsole.Items
{
    internal class DreadPlate:Item
    {
        public DreadPlate() : base("こわもてプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Dark;
            }
        }

    }
}
