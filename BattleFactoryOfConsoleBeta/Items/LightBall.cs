namespace BattleOfConsole.Items
{
    internal class LightBall:Item
    {
        public LightBall() : base("でんきだま")
        {
        }

        public override void ItemEffect(Pokemon pokemon, Pokemon target, Skill selectskill)
        {
            base.ItemEffect(pokemon, target, selectskill);
            {
                if (pokemon.Name == "ピカチュウ")
                {
                    pokemon.IA *= 2;
                    pokemon.IC *= 2;
                }
            }
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                if (pokemon.Name == "ピカチュウ")
                {
                    Check check = new Check();
                    pokemon.IA = pokemon.InitialArank;
                    pokemon.IC = pokemon.InitialCrank;
                    check.CheckRankState(pokemon);
                }
            }
        }
    }
}
