namespace BattleOfConsole.Items
{
    internal class BoostEnergy:Item
    {
        public BoostEnergy() : base("ブーストエナジー")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon,Pokemon target)
        {
            NoneItem none = new NoneItem();
            if((pokemon.Abilities.Name == "クォークチャージ") || (pokemon.Abilities.Name == "こだいかっせい"))
            {
                Console.WriteLine($"{pokemon.Name}はブーストエナジーで{pokemon.Abilities.Name}をはつどうした!");
                Console.WriteLine($"ブーストエナジーはやくわりをおえてきえてしまった!");
                pokemon.HaveItem = none;
            }
        }
        
    }
}
