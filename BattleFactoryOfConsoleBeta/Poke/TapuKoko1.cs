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
    internal class Tapukoko1 : Pokemon
    {
        public Tapukoko1() : base("カプ・コケコ", 282, 239, 206, 289, 186, 394, Type.Types.Elec,Type.Types.Fairy)
        {
            Skill skill1= new BraveBird();
            Skill skill2= new WildCharge();
            Skill skill3 = new SteelWing();
            Skill skill4= new QuickAttack();
            Ability ability = new ElectricSurge();
            Item item = new AssaultVest(this);
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
