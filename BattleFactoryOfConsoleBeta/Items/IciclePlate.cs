namespace BattleOfConsole.Items
{
    internal class IciclePlate:Item
    {
        public IciclePlate() : base("つららのプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Ice;
            }
        }

    }
}
