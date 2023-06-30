using static BattleOfConsole.Skill;
using static System.Formats.Asn1.AsnWriter;

namespace BattleOfConsole.Items
{
    internal class StonePlate:Item
    {
        public StonePlate() : base("がんせきプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Rock;
            }
        }

    }
}
