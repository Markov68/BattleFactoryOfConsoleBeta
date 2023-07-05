using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BattleOfConsole.Abilities;
using BattleOfConsole.Items;
using BattleOfConsole.Skills;

namespace BattleOfConsole
{
    internal class Drapion1 : Pokemon
    {
        public Drapion1() : base("ドラピオン", 344, 306, 257, 140, 186, 226, Type.Types.Poison,Type.Types.Dark)
        {
            Skill skill1= new CrossPoison();
            Skill skill2= new NightSlash();
            Skill skill3 = new XScissor();
            Skill skill4= new Taunt();
            Ability ability = new Sniper();
            Item item = new ScopeLens();
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
