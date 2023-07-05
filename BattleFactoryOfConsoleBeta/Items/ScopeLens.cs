using static System.Formats.Asn1.AsnWriter;

namespace BattleOfConsole.Items
{
    internal class ScopeLens:Item
    {
        public ScopeLens() : base("ピントレンズ")
        { 
        }

        public override void ItemEffect(Pokemon pokemon, Pokemon target, Skill selectskill)
        {
            base.ItemEffect(pokemon, target, selectskill);
            {
                pokemon.CriticalHitStage += 1;
            }
        }

    }
}
