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
    internal class Flareon1 : Pokemon
    {
        public Flareon1() : base("ブースター", 334, 394, 157, 226, 256, 149, Type.Types.Fire,Type.Types.None)
        {
            Skill skill1= new FlameFang();
            Skill skill2= new QuickAttack();
            Skill skill3 = new Trailblaze();
            Skill skill4= new Curse();
            Ability ability = new Guts();
            Item item = new ToxicOrb();
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
