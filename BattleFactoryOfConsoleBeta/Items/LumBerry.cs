namespace BattleOfConsole.Items
{
    internal class LumBerry:Item
    {
        public LumBerry() : base("ラムのみ")
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
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}をたべてやけどをなおした!");
                    pokemon.HaveItem = noneItem;
                }
                else if (pokemon.State == Pokemon.Statements.Sleep)
                {
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}をたべてねむりからめざめた!!");
                    pokemon.State = Pokemon.Statements.None;
                    pokemon.HaveItem = noneItem;
                }
                else if ((pokemon.State == Pokemon.Statements.Poison) || (pokemon.State == Pokemon.Statements.Toxic))
                {
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}をたべてどくじょうたいをなおした!!");
                    pokemon.State = Pokemon.Statements.None;
                    pokemon.HaveItem = noneItem;
                }
                else if (pokemon.State == Pokemon.Statements.Paralyze)
                {
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}をたべてしびれをとった!");
                    pokemon.State = Pokemon.Statements.None;
                    pokemon.HaveItem = noneItem;
                }
                else if (pokemon.Confusion == true)
                {
                    pokemon.Confusion = false;
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}をたべてしょうきにもどった!");
                    pokemon.HaveItem = noneItem;
                }
            }
        }

    }
}
