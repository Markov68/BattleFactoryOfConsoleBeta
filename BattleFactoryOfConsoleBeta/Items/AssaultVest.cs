namespace BattleOfConsole.Items
{
    internal class AssaultVest:Item
    {
        public AssaultVest(Pokemon pokemon) : base("とつげきチョッキ")
        {
        }

        public override void ItemEffect(Pokemon pokemon, Pokemon target, Skill selectskill)
        {
            base.ItemEffect(pokemon, target, selectskill);
            {
                pokemon.ID = (int)(pokemon.ID * 1.5);
            }
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                Check check = new Check();
                pokemon.ID = pokemon.InitialID;
                check.CheckRankState(pokemon);
            }
        }

    }
}
