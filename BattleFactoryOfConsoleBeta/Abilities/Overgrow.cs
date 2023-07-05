//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class Overgrow : Ability
    {
        public Overgrow() : base("しんりょく")
        {
        }

        public override void AbilityEffect(Pokemon pokemon, Pokemon target)
        {
            base.AbilityEffect(pokemon, target);
            {
                if((pokemon.IH <= pokemon.InitialIH / 3) && (pokemon.SelectedSkill.SkillType == Type.Types.Leaf)) 
                {
                    pokemon.Abilities.AbilityEffectCount = 1.5;
                }
            }
        }

    }
}
