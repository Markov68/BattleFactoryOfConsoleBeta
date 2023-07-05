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
    internal class Scizor1 : Pokemon
    {
        public Scizor1() : base("ハッサム", 282, 394, 299, 131, 259, 166, Type.Types.Bug,Type.Types.Metal)
        {
            Skill skill1= new XScissor();
            Skill skill2= new Uturn();
            Skill skill3 = new AerielAce();
            Skill skill4= new QuickAttack();
            Ability ability = new Technician();
            Item item = new OccaBerry();
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
