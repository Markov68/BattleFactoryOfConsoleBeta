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
    internal class Gastrodon1 : Pokemon
    {
        public Gastrodon1() : base("トリトドン",426,181,172,221,289,114,Type.Types.Water,Type.Types.Grand)
        {
            Skill skill1 = new EarthPower();
            Skill skill2= new Surf();
            Skill skill3 = new AcidArmor();
            Skill skill4= new Amnesia();
            Ability ability = new StormDrain();
            Item haveitem = new LeftOvers();
            AddSkill(skill1);
            AddSkill(skill2);
            AddSkill(skill3);
            AddSkill(skill4);
            Abilities = ability;
            HaveItem = haveitem;
            InitialAbilities = Abilities;
            InitialHaveItem = HaveItem;
        }

    }

}
