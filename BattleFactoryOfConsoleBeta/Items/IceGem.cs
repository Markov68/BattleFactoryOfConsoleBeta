using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class IceGem:Item
    {
        public IceGem() : base("こおりのジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Ice;
            }
        }

    }
}
