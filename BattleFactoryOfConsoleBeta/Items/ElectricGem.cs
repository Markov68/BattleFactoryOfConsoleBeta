using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class ElectricGem : Item
    {
        public ElectricGem() : base("でんきのジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Elec;
            }
        }

    }
}
