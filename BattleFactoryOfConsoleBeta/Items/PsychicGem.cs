using BattleOfConsole.Skills;
using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class PsychicGem:Item
    {
        public PsychicGem() : base("エスパージュエル")
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
