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
    internal class Metagross1 : Pokemon
    {
        public Metagross1() : base("メタグロス", 364, 275, 296, 317, 216, 177, Type.Types.Metal,Type.Types.Psy)
        {
            Skill skill1= new Psychic();
            Skill skill2= new FlashCannon();
            Skill skill3 = new ThunderBolt();
            Skill skill4= new Trick();
            Ability ability = new ClearBody();
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
