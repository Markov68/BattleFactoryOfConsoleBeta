using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfConsole.Abilities;
using BattleOfConsole.Items;
using BattleOfConsole.Skills;

namespace BattleOfConsole
{
    internal class Garchomp1 : Pokemon
    {
        public Garchomp1() : base("ガブリアス", 358, 394, 226, 176, 206, 303, Type.Types.Dragon,Type.Types.Grand)
        {
            Skill skill1= new DragonDive();
            Skill skill2= new IronTail();
            Skill skill3 = new SwordDance();
            Skill skill4= new FlameFang();
            Ability ability = new RoughSkin();
            Item item = new LifeOrb();
            AddSkill(skill1);
            AddSkill(skill2);
            AddSkill(skill3);
            AddSkill(skill4);
            Abilities = ability;
            HaveItem = item;
            InitialAbilities = Abilities;
            InitialHaveItem = HaveItem;
        }

    }

}
