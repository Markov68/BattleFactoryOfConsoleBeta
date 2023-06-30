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
    internal class Pikachu1 : Pokemon
    {
        public Pikachu1() : base("ピカチュウ", 211, 209, 116, 137, 122, 306, Type.Types.Elec,Type.Types.None)
        {
            Skill skill1= new ThunderBolt();
            Skill skill2= new QuickAttack();
            Skill skill3 = new IronTail();
            Skill skill4= new VoltTackle();
            Ability ability = new Static();
            Item item = new LightBall();
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
