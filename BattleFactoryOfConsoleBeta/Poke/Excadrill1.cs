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
    internal class Excadrill1 : Pokemon
    {
        public Excadrill1() : base("ドリュウズ", 386, 217, 248, 266, 248, 278, Type.Types.Grand,Type.Types.Metal)
        {
            Skill skill1= new Earthquake();
            Skill skill2= new IronHead();
            Skill skill3 = new SwordDance();
            Skill skill4= new Sandstorm();
            Ability ability = new SandRush();
            Item item = new EarthPlate();
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
