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
    internal class Salamence1 : Pokemon
    {
        public Salamence1() : base("ボーマンダ", 332, 369, 196, 230, 196, 328, Type.Types.Dragon,Type.Types.Fly)
        {
            Skill skill1= new DragonDance();
            Skill skill2= new Crunch();
            Skill skill3 = new DragonClaw();
            Skill skill4= new ZenHeadButt();
            Ability ability = new Threat();
            Item item = new MuscleBand();
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
