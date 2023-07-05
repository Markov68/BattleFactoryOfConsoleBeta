using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole
{
    internal class Item
    {
        public string Name;

        public Item(string name)
        {
            Name = name;
        }

        public double ItemDamageEffect { get; set; } = 1;

        public Type.Types TypeEnhance { get; set; } = Type.Types.None;

        public static double TypeEnhanceCounter { get; set; } = 1;

        public bool IHMaxToZero { get; set; } = false;

        public virtual void ItemEffect(Pokemon pokemon,Pokemon target,Skill selectskill) 
        {
            pokemon.HaveItem.ItemDamageEffect = 1;
        }

        public virtual void FirstPutEffect(Pokemon pokemon,Pokemon target) 
        {
        }

        public virtual void BeforeDamageEffect(Pokemon pokemon,Pokemon target,double damage) 
        {
        }

        public virtual void BeforeDamageEffect(Pokemon pokemon, Pokemon target, ref double damage)
        {
        }
        public virtual void AfterDamageEffect(Pokemon pokemon,Pokemon target,double damage) 
        {
        }

        public virtual void AfterAttackEffect(Pokemon pokemon, Pokemon target, double damage)
        {
        }

        public virtual void EndTurnEffect(Pokemon pokemon,Pokemon target) 
        {
        }

        public virtual void ItemStateEffect(Pokemon pokemon) 
        {
        }

        public virtual void ItemCounterEffect(Pokemon pokemon,Pokemon target) 
        {
        }
    }
}
