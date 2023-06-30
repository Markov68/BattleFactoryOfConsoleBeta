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
    internal class Torkoal1 : Pokemon
    {
        public Torkoal1() : base("コータス", 344, 185, 416, 207, 176, 76, Type.Types.Fire,Type.Types.None)
        {
            Skill skill1= new OverHeat();
            Skill skill2= new ClearSmog();
            Skill skill3 = new Yawn();
            Skill skill4= new WillOWisp();
            Ability ability = new Drought();
            Item item = new EjectPack();
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
