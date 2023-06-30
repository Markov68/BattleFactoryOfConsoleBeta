using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class DragonGem:Item
    {
        public DragonGem() : base("ドラゴンジュエル")
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
