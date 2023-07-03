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
    internal class Nihilego1: Pokemon
    {
        public Nihilego1() : base("ウツロイド", 422, 127, 130, 291, 298, 335, Type.Types.Poison,Type.Types.Rock)
        {
            Skill skill1= new LightScreen();
            Skill skill2= new Sandstorm();
            Skill skill3 = new SludgeBomb();
            Skill skill4= new PowerGem();
            Ability ability = new BeastBoost();
            Item item = new PoisonGem();
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
