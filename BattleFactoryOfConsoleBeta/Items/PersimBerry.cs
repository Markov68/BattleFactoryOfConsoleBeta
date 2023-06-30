namespace BattleOfConsole.Items
{
    internal class PersimBerry:Item
    {
        public PersimBerry() : base("キーのみ")
        { 
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                Check check = new Check();
                NoneItem noneItem = new NoneItem();
                if (pokemon.Confusion == true)
                {
                    pokemon.Confusion = false;
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}をたべてしょうきにもどった!");
                    pokemon.HaveItem = noneItem;
                }
            }
        }

    }
}
