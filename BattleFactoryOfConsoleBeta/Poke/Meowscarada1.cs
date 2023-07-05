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
    internal class Meowscarada1 : Pokemon
    {
        public Meowscarada1() : base("マスカーニャ", 294, 230, 176, 287, 176, 345, Type.Types.Leaf,Type.Types.Dark)
        {
            Skill skill1= new AuraSphere();
            Skill skill2= new ShadowBall();
            Skill skill3 = new GigaDrain();
            Skill skill4= new NastyPlot();
            Ability ability = new Protean();
            Item item = new WiseGlasses();
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
