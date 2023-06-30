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
    internal class Staraptor1 : Pokemon
    {
        public Staraptor1() : base("ムクホーク", 312, 339, 176, 122, 156, 328, Type.Types.Nomal,Type.Types.Fly)
        {
            Skill skill1= new GigaImpact();
            Skill skill2= new BraveBird();
            Skill skill3 = new Uturn();
            Skill skill4= new CloseCombat();
            Ability ability = new Threat();
            Item item = new ChoiceScarf();
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
