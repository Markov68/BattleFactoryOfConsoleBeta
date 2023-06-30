namespace BattleOfConsole.Items
{
    internal class MuscleBand:Item
    {
        public MuscleBand() : base("ちからのハチマキ")
        { 
        }

        public override void ItemEffect(Pokemon pokemon,Pokemon target,Skill selectskill)
        {
            base.ItemEffect(pokemon,target,selectskill);
            {
                if (pokemon.SelectedSkill.Kinds == Skill.Kind.attack)
                {
                    ItemDamageEffect = 1.1;
                }
            }
        }

    }
}
