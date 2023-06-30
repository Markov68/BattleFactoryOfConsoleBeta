using System.Collections.Generic;
using static BattleOfConsole.Skill;

namespace BattleOfConsole.Items
{
    internal class InsectPlate:Item
    {
        public InsectPlate() : base("たまむしプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Bug;
            }
        }

    }
}
