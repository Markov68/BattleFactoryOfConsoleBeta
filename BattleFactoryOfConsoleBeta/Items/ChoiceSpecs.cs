﻿namespace BattleOfConsole.Items
{
    internal class ChoiceSpecs : Item
    {
        public ChoiceSpecs() : base("こだわりメガネ")
        { 
        }

        public override void ItemEffect(Pokemon pokemon,Pokemon target,Skill selectskill)
        {
            base.ItemEffect(pokemon,target,selectskill);
            {
                if(pokemon.SelectLockSkill != null) 
                {
                    if ((pokemon.SelectedSkill.Kinds == Skill.Kind.cattack) || (pokemon.SelectLockSkill.Kinds == Skill.Kind.cattack))
                    {
                        pokemon.HaveItem.ItemDamageEffect = 1.5;
                    }
                }
            }
        }

    }
}
