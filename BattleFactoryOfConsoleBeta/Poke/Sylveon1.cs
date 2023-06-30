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
    internal class Sylveon1 : Pokemon
    {
        public Sylveon1() : base("ニンフィア",394,149,166,350,297,156,Type.Types.Fairy,Type.Types.None)
        {
            Skill skill1 = new CalmMind();
            Skill skill2 = new Rest();
            Skill skill3 = new Psychic();
            Skill skill4= new DazzlingGlam();
            Ability ability = new Pixilate();
            Item haveitem = new ChestoBerry();
            AddSkill(skill1);
            AddSkill(skill2);
            AddSkill(skill3);
            AddSkill(skill4);
            Abilities = ability;
            HaveItem = haveitem;
            InitialAbilities = Abilities;
            InitialHaveItem = HaveItem;
        }

    }

}
