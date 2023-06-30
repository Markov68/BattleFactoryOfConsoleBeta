using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class FairyGem:Item
    {
        public FairyGem() : base("フェアリージュエル")
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
