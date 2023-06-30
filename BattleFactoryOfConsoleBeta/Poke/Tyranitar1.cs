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
    internal class Tyranitar1 : Pokemon
    {
        public Tyranitar1() : base("バンギラス",404,403,256,203,237,158,Type.Types.Rock,Type.Types.Dark)
        {
            Skill skill1 = new ThunderPanch();
            Skill skill2= new FramePunch();
            Skill skill3 = new IcePanch();
            Skill skill4= new DragonDance();
            Ability ability = new SandStream();
            Item haveitem = new SitrusBerry();
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
