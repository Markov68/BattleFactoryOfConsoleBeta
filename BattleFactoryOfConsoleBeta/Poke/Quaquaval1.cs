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
    internal class Quaquaval1 : Pokemon
    {
        public Quaquaval1() : base("ウェーニバル", 312, 339, 196, 185, 186, 295, Type.Types.Water,Type.Types.Fight)
        {
            Skill skill1= new AquaStep();
            Skill skill2= new LowSweep();
            Skill skill3 = new AerielAce();
            Skill skill4= new Roost();
            Ability ability = new Moxie();
            Item item = new CheriBerry();
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
