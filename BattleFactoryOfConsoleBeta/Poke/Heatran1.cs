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
    internal class Heatran1 : Pokemon
    {
        public Heatran1() : base("ヒードラン", 386, 306, 248, 266, 248, 191, Type.Types.Fire,Type.Types.Metal)
        {
            Skill skill1= new Crunch();
            Skill skill2= new FlameFang();
            Skill skill3 = new Earthquake();
            Skill skill4= new StoneEdge();
            Ability ability = new FlashFire();
            Item item = new FireGem();
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
