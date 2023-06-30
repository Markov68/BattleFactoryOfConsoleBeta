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
            if(pokemon.Abilities.Name == "クォークチャージ") 
            {
                Console.WriteLine($"{pokemon.Name}はブーストエナジーでクォークチャージをはつどうした!");
                Console.WriteLine($"ブーストエナジーはやくわりをおえてきえてしまった!");
                pokemon.HaveItem = none;
            }
        }
        
    }
}
