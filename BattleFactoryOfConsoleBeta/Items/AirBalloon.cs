namespace BattleOfConsole.Items
{
    internal class AirBalloon:Item
    {
        public AirBalloon() : base("ふうせん")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}でういている!");
            }
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                NoneItem noneItem = new NoneItem();
                pokemon.HaveItem = noneItem;
                Console.WriteLine($"{pokemon.Name}の{pokemon.HaveItem.Name}がわれた!");
            }
        }

    }
}
