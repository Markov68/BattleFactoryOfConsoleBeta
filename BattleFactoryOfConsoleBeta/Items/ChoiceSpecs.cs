namespace BattleOfConsole.Items
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
                if((pokemon.SelectedSkill.Kinds == Skill.Kind.cattack) || (pokemon.SelectLockSkill.Kinds == Skill.Kind.cattack)) 
                {
                    ItemDamageEffect = 1.5;
                }
            }
        }

    }
}
