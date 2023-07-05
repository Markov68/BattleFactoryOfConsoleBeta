namespace BattleOfConsole.Items
{
    internal class LeftOvers : Item
    {
        public LeftOvers() : base("たべのこし")
        {
        }

        public override void EndTurnEffect(Pokemon pokemon, Pokemon target)
        {
            base.EndTurnEffect(pokemon, target);
            {
                Check check = new Check();
                if((pokemon.IH != pokemon.InitialIH) && (pokemon.IH != 0)) 
                {
                    pokemon.IH += pokemon.InitialIH / 16;
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}でたいりょくをすこしかいふく");
                    check.CheckIH(pokemon);
                }
            }
        }

    }
}
