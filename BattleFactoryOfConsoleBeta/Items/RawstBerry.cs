namespace BattleOfConsole.Items
{
    internal class RawstBerry : Item
    {
        public RawstBerry() : base("チーゴのみ")
        { 
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                Check check = new Check();
                NoneItem noneItem = new NoneItem();
                if (pokemon.State == Pokemon.Statements.Burn)
                {
                    pokemon.State = Pokemon.Statements.None;
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}をたべてやけどをかいふくした!");
                    pokemon.HaveItem = noneItem;
                }
            }
        }


    }
}
