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
    internal class Kingdra1 : Pokemon
    {
        public Kingdra1() : base("キングドラ", 354, 227, 226, 203, 226, 295, Type.Types.Water,Type.Types.Dragon)
        {
            Skill skill1= new Waterfall();
            Skill skill2= new BreakingSwipe();
            Skill skill3 = new DragonDance();
            Skill skill4= new RainDance();
            Ability ability = new SandRush();
            Item item = new SplashPlate();
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
