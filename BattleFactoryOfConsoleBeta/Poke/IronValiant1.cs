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
    internal class IronValiant1 : Pokemon
    {
        public IronValiant1() : base("テツノブジン", 290, 266, 216, 339, 156, 364, Type.Types.Fairy,Type.Types.Fight)
        {
            Skill skill1= new Trick();
            Skill skill2= new AuraSphere();
            Skill skill3 = new DazzlingGlam();
            Skill skill4= new ElectricTerrain();
            Ability ability = new QuarkDrive(this);
            Item item = new ChoiceSpecs();
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
