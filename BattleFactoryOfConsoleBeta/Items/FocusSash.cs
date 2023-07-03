namespace BattleOfConsole.Items
{
    internal class FocusSash : Item
    {
        public FocusSash() : base("きあいのタスキ")
        {
        }

        

        public override void BeforeDamageEffect(Pokemon pokemon, Pokemon target, ref double damage)
        {
            base.BeforeDamageEffect(pokemon, target, ref damage);
            {
                if ((pokemon.IH == pokemon.InitialIH) && (pokemon.IH <= damage))
                {
                    pokemon.IHMAXToZero = true;
                }
            }
        }
        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            base.AfterDamageEffect(pokemon, target,damage);
            {
                Check check = new Check();
                NoneItem noneItem = new NoneItem();
                if ((pokemon.IH == 0) && (pokemon.IHMAXToZero == true))
                {
                    pokemon.IH = 1;
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}でもちこたえた!!");
                    pokemon.HaveItem = noneItem;
                    pokemon.IHMAXToZero = false;
                }
                else 
                {
                    pokemon.IHMAXToZero = false;
                }
            }
        }


    }
}
