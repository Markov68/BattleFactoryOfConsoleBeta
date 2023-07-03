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
    internal class Umbreon1 : Pokemon
    {
        public Umbreon1() : base("ブラッキー", 394, 149, 350, 156, 297, 166, Type.Types.Dark,Type.Types.None)
        {
            Skill skill1= new LightScreen();
            Skill skill2= new Reflect();
            Skill skill3 = new DarkPulse();
            Skill skill4= new Toxic();
            Ability ability = new InnerFocus();
            Item item = new LightClay();
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
