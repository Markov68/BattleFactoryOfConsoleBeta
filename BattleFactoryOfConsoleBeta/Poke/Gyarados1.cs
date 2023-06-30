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
    internal class Gyarados1 : Pokemon
    {
        public Gyarados1() : base("ギャラドス",332,383,194,140,236,261,Type.Types.Water,Type.Types.Fly)
        {
            Skill icefang = new IceFang();
            Skill aquatail= new AquaTail();
            Skill dragondance = new DragonDance();
            Skill raindance= new RainDance();
            Ability threat = new Threat();
            Item lumberry = new LumBerry();
            AddSkill(icefang);
            AddSkill(aquatail);
            AddSkill(dragondance);
            AddSkill(raindance);
            Abilities = threat;
            HaveItem = lumberry;
            InitialAbilities = Abilities;
            InitialHaveItem = HaveItem;
        }

    }

}
