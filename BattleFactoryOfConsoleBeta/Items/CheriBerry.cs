namespace BattleOfConsole.Items
{
    internal class CheriBerry : Item
    {
        public CheriBerry() : base("クラボのみ")
        { 
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                Check check = new Check();
                NoneItem noneItem = new NoneItem();
                if (pokemon.State == Pokemon.Statements.Paralyze)
                {
                    pokemon.State = Pokemon.Statements.None;
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}をたべてしびれをとった!");
                    pokemon.HaveItem = noneItem;
                }
            }
        }


    }
}
