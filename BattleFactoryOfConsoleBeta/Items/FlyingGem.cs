using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class FlyingGem:Item
    {
        public FlyingGem() : base("ひこうのジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Fly;
            }
        }

    }
}
