namespace BattleOfConsole.Items
{
    internal class ChestoBerry:Item
    {
        public ChestoBerry() : base("カゴのみ")
        { 
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            base.AfterDamageEffect(pokemon, target,damage);
            {
                NoneItem noneItem = new NoneItem();
                if(pokemon.State == Pokemon.Statements.Sleep) 
                {
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}をたべてねむりからめざめた!!");
                    pokemon.State = Pokemon.Statements.None;
                    pokemon.HaveItem = noneItem;
                }
            }
        }

    }
}
