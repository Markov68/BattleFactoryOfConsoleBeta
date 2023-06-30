namespace BattleOfConsole.Items
{
    internal class SitrusBerry : Item
    {
        public SitrusBerry() : base("オボンのみ")
        { 
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                Check check = new Check();
                NoneItem noneItem = new NoneItem();
                if((pokemon.IH <= pokemon.InitialIH / 2) && (pokemon.IH != 0))
                {
                    pokemon.IH += pokemon.InitialIH / 4;
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}をたべてたいりょくをかいふくした!");
                    pokemon.HaveItem = noneItem;
                }
            }
        }


    }
}
