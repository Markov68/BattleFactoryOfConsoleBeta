using System.Diagnostics;
using static BattleOfConsole.Skill;

namespace BattleOfConsole.Items
{
    internal class IronPlate:Item
    {
        public IronPlate() : base("こうてつプレート")
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
