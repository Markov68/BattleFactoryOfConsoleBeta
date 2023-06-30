using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class FireGem: Item
    {
        public FireGem() : base("ほのおのジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Fire;
            }
        }

    }
}
