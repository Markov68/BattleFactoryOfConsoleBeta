using System.Numerics;

namespace BattleOfConsole.Items
{
    internal class BugGem:Item
    {
        public BugGem() : base("むしのジュエル")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Bug;
            }
        }

    }
}
