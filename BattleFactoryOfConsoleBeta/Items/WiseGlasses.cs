namespace BattleOfConsole.Items
{
    internal class WiseGlasses:Item
    {
        public WiseGlasses() : base("ものしりメガネ")
        { 
        }

        public override void ItemEffect(Pokemon pokemon,Pokemon target,Skill selectskill)
        {
            base.ItemEffect(pokemon,target,selectskill);
            {
                if (pokemon.SelectedSkill.Kinds == Skill.Kind.cattack)
                {
                    pokemon.HaveItem.ItemDamageEffect = 1.1;
                }
            }
        }

    }
}
