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
    internal class Politoed1 : Pokemon
    {
        public Politoed1() : base("ニョロトノ", 384, 249, 205, 194, 236, 176, Type.Types.Water,Type.Types.None)
        {
            Skill skill1= new Liquidation();
            Skill skill2= new BrickBreak();
            Skill skill3 = new Hypnosis();
            Skill skill4= new Swagger();
            Ability ability = new Drizzle();
            Item item = new DampRock();
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
