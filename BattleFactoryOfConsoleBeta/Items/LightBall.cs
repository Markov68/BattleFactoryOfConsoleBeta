namespace BattleOfConsole.Items
{
    internal class LightBall:Item
    {
        public LightBall() : base("でんきだま")
        {
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                if(pokemon.Name == "ピカチュウ")
                {
                    pokemon.IA *= 2;
                    pokemon.IC *= 2;
                }
            }
        }
    }
}
