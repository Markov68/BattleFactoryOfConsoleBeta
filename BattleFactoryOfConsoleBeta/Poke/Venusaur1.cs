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
    internal class Venusaur1 : Pokemon
    {
        public Venusaur1() : base("フシギバナ", 364, 180, 202, 237, 328, 196, Type.Types.Leaf,Type.Types.Poison)
        {
            Skill skill1= new GigaDrain();
            Skill skill2= new EarthPower();
            Skill skill3 = new SludgeBomb();
            Skill skill4= new Amnesia();
            Ability ability = new Overgrow();
            Item item = new ShellBell();
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
