using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class NormalGem: Item
    {
        public NormalGem() : base("ノーマルジュエル")
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
