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
    internal class Ceruledge1 : Pokemon
    {
        public Ceruledge1() : base("ソウブレイズ", 291, 383, 197, 140, 236, 269, Type.Types.Gohst,Type.Types.Fire)
        {
            Skill skill1= new BitterBlade();
            Skill skill2= new IronHead();
            Skill skill3 = new DragonClaw();
            Skill skill4= new PoisonJab();
            Ability ability = new WeakArmor();
            Item item = new FocusSash();
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
