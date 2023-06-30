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
    internal class Armarouge1 : Pokemon
    {
        public Armarouge1() : base("グレンアルマ", 374, 140, 237, 383, 196, 186, Type.Types.Fire,Type.Types.Psy)
        {
            Skill skill1= new WillOWisp();
            Skill skill2= new MysticalFire();
            Skill skill3 = new FlashCannon();
            Skill skill4= new CalmMind();
            Ability ability = new FlashFire();
            Item item = new LeftOvers();
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
