using static BattleOfConsole.Skill;

namespace BattleOfConsole.Items
{
    internal class MindPlate:Item
    {
        public MindPlate() : base("ふしぎのプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Psy;
            }
        }

    }
}
