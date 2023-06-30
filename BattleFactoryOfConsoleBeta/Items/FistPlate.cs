using System.Collections.Generic;

namespace BattleOfConsole.Items
{
    internal class FistPlate:Item
    {
        public FistPlate() : base("こぶしのプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Fight;
            }
        }

    }
}
