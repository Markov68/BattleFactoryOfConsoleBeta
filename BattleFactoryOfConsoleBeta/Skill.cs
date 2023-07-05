using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole
{
    internal class Skill
    {
        int _pp;
        public string Name { get; set; }
        public Type.Types SkillType { get; set; }
        public Kind Kinds { get; set; }
        public int Impact { get; set; }
        public int Selectedskill { get; set; }

        public int HitRate { get; set; }

        public int PP
        {
            get
            {
                return _pp;
            }
            set
            {
                if (PP < 0)
                {
                    _pp = 0;
                }
                else
                {
                    _pp = value;
                }
            }
        }

        public int Priority { get; set; }
        public bool IsTouchSkill { get; set; }

        public enum Kind
        {
            attack,
            cattack,
            change,
            oneshot
        }

        public Skill(string name, Type.Types type, Kind kind, int impact,int pP, int hitRate, int priority, bool isTouchSkill)
        {
            Name = name;
            SkillType = type;
            Kinds = kind;
            Impact = impact;
            PP = pP;
            HitRate = hitRate;
            Priority = priority;
            IsTouchSkill = isTouchSkill;
        }

        public virtual void BeforedamageEffect(Pokemon pokemon, Pokemon target)
        { 
        }

        public virtual void BeforeAttackEffect(Pokemon pokemon,Pokemon target)
        {
        }
        public virtual void AfterDamageEffect(Pokemon pokemon,Pokemon target,double damage) 
        {
        }

        public virtual void ChangeSkillEffect(Pokemon pokemon ,Pokemon target,Weather.Weathers weather) 
        {
        }

        


    }
}
