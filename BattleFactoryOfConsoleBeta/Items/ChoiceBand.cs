﻿namespace BattleOfConsole.Items
{
    internal class ChoiceBand:Item
    {
        public ChoiceBand() : base("こだわりハチマキ")
        { 
        }

        public override void ItemEffect(Pokemon pokemon,Pokemon target,Skill selectskill)
        {
            base.ItemEffect(pokemon,target,selectskill);
            {
                if(pokemon.SelectLockSkill != null) 
                {
                    if ((pokemon.SelectedSkill.Kinds == Skill.Kind.attack) || (pokemon.SelectLockSkill.Kinds == Skill.Kind.attack))
                    {
                        pokemon.HaveItem.ItemDamageEffect = 1.5;
                    }
                }
     
            }
        }

    }
}
