using BattleOfConsole.Skills;

namespace BattleOfConsole.Items
{
    internal class ToxicPlate:Item
    {
        public ToxicPlate() : base("もうどくプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Poison;
            }
        }

    }
}
