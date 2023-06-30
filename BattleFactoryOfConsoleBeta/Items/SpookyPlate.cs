using static BattleOfConsole.Skill;

namespace BattleOfConsole.Items
{
    internal class SpookyPlate:Item
    {
        public SpookyPlate() : base("もののけプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Gohst;
            }
        }

    }
}
