namespace BattleOfConsole.Items
{
    internal class EarthPlate:Item
    {
        public EarthPlate() : base("だいちのプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Grand;
            }
        }

    }
}
