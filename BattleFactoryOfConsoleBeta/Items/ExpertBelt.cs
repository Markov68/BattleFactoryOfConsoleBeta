namespace BattleOfConsole.Items
{
    internal class ExpertBelt:Item
    {
        public ExpertBelt() : base("たつじんのおび")
        { 
        }

        public override void ItemEffect(Pokemon pokemon,Pokemon target,Skill selectskill)
        {
            base.ItemEffect(pokemon,target,selectskill);
            {
                Type type = new Type();
                type.TypeEffect(target, selectskill);
                if(type.EffectivCounter >= 2) 
                {
                    ItemDamageEffect = 1.2;
                }
            }
        }


    }
}
