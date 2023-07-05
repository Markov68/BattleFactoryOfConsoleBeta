//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class Guts : Ability
    {
        public Guts() : base("こんじょう")
        {
        }

        public override void AbilityEffect(Pokemon pokemon, Pokemon target)
        {
            base.AbilityEffect(pokemon, target);
            {
                if((pokemon.State != Pokemon.Statements.None) && (pokemon.SelectedSkill.Kinds == Skill.Kind.attack))
                {
                    pokemon.Abilities.AbilityEffectCount = 1.5;
                    pokemon.BurnGainIA = 1;
                }
            }
        }

    }
}
