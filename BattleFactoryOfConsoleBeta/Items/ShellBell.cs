namespace BattleOfConsole.Items
{
    internal class ShellBell:Item
    {
        public ShellBell() : base("かいがらのすず")
        { 
        }

        public override void AfterAttackEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            base.AfterAttackEffect(pokemon, target,damage);
            {
                Check check = new Check();
                if(damage != 0) 
                {
                    if(damage < 8) 
                    {
                        pokemon.IH += 1;
                        Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}でたいりょくをかいふくした!");
                        check.CheckIH(pokemon);
                    }
                    else 
                    {
                        pokemon.IH += (int)damage / 8;
                        Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}でたいりょくをかいふくした!");
                        check.CheckIH(pokemon);
                    }
                }
            }
        }


    }
}
