using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class DarkGem:Item
    {
        public DarkGem() : base("あくのジュエル")
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
