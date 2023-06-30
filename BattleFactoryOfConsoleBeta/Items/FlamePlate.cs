namespace BattleOfConsole.Items
{
    internal class FlamePlate:Item
    {
        public FlamePlate() : base("ひのたまプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Fire;
            }
        }

    }
}
