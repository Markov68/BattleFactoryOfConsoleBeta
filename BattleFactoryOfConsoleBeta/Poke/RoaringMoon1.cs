using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfConsole.Items;
using BattleOfConsole.Skills;

namespace BattleOfConsole
{
    internal class RoaringMoon1 : Pokemon
    {
        public RoaringMoon1() : base("トドロクツキ", 352, 282, 178, 229, 238, 337,Type.Types.Dark,Type.Types.Fly) 
        {
            Skill skill1= new Thunder();
            Skill skill2 = new Hydropump();
            Skill skill3 = new DracoMeteor();
            Skill skill4 = new DarkPulse();
            Item haveitem= new BoostEnergy();
            Ability ability = new Protosynthesis(this);
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
