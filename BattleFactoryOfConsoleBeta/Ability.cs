using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole
{
    internal class Ability
    {
        public string Name { get; set; }

        public Type.Types TypeEnhance { get; set; }

        public double TypeEnhanceCounter { get; set; } = 1;

        public Ability(string name) 
        {
            Name = name;
        }

        public static double AbilityEffectCount{ get; set; } = 1;

        public virtual void FirstPutEffect(Pokemon pokemon,Pokemon target,Field.Fields field,Weather.Weathers wheather) 
        {
        }

        public virtual void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage) 
        {

        }

        public virtual void AbilityEffect(Pokemon pokemon, Pokemon target)
        {
            Ability.AbilityEffectCount = 1;
        }

        public virtual void AttackFaintedEffect(Pokemon pokemon,Pokemon target) 
        {
        
        }


    }
}
