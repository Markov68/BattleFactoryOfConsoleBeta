using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class GrassGem:Item
    {
        public GrassGem() : base("くさのジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Leaf;
            }
        }

    }
}
