using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class BlankPlate:Item
    {
        public BlankPlate() : base("まっさらプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Nomal;
            }
        }

    }
}
