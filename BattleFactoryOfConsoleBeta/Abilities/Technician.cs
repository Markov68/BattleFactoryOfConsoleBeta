//using BattleOfConsole.Fields;

namespace BattleOfConsole.Abilities
{
    internal class Technician : Ability
    {
        public Technician() : base("テクニシャン")
        {
        }

        public override void AbilityEffect(Pokemon pokemon, Pokemon target)
        {
            base.AbilityEffect(pokemon, target);
            {
                if(pokemon.SelectedSkill.Impact <= 60) 
                {
                    Ability.AbilityEffectCount = 1.5;
                }
            }
        }

    }
}
