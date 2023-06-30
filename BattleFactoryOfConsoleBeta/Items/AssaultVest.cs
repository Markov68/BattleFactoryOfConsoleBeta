namespace BattleOfConsole.Items
{
    internal class AssaultVest:Item
    {
        public AssaultVest(Pokemon pokemon) : base("とつげきチョッキ")
        {
            pokemon.ID = (int)(pokemon.ID * 1.5);
        }

        public override void FirstPutEffect(Pokemon pokemon,Pokemon target)
        {
            pokemon.ID = (int)(pokemon.ID * 1.5);
        }
        
    }
}
