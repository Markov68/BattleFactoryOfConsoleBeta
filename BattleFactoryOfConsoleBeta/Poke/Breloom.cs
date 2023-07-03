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
    internal class Breloom1 : Pokemon
    {
        public Breloom1() : base("キノガッサ", 324, 394, 194, 140, 156, 176, Type.Types.Leaf,Type.Types.Fight)
        {
            Skill skill1= new MachPunch();
            Skill skill2= new SeedBomb();
            Skill skill3 = new LeechSeed();
            Skill skill4= new Spore();
            Ability ability = new Technician();
            Item item = new CobaBerry();
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
