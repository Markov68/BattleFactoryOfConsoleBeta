//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class Sniper : Ability
    {
        public Sniper() : base("スナイパー")
        {
        }

        public override void AbilityEffect(Pokemon pokemon, Pokemon target)
        {
            base.AbilityEffect(pokemon, target);
            {
                pokemon.CriticalHitStage += 1;
            }
        }

    }
}
