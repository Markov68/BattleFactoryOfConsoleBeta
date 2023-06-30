namespace BattleOfConsole.Items
{
    internal class SplashPlate:Item
    {
        public SplashPlate() : base("しずくプレート")
        { 
        }

        public override void FirstPutEffect(Pokemon pokemon, Pokemon target)
        {
            base.FirstPutEffect(pokemon, target);
            {
                pokemon.HaveItem.TypeEnhance = Type.Types.Water;
            }
        }

    }
}
