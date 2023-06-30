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
    internal class Lucario1 : Pokemon
    {
        public Lucario1() : base("ルカリオ", 282, 350, 176, 239, 176, 279,Type.Types.Metal,Type.Types.Fight) 
        {
            Skill lowSweep = new LowSweep();
            Skill thunderPanch= new ThunderPanch();
            Skill icePanch = new IcePanch();
            Skill aerielAce= new AerielAce();
            Ability innerFocus = new InnerFocus();
            Item expertBelt = new ExpertBelt();
            AddSkill(lowSweep);
            AddSkill(thunderPanch);
            AddSkill(icePanch);
            AddSkill(aerielAce);
            Abilities = innerFocus;
            HaveItem = expertBelt;
            InitialAbilities = Abilities;
            InitialHaveItem = HaveItem;
        }

    }

}
