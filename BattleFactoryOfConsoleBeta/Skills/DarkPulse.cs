namespace BattleOfConsole.Skills
{
    internal class DarkPulse : Skill
    {
        public DarkPulse() : base("あくのはどう", Type.Types.Fight, Kind.cattack, 80, 20, 1000, 0, false)
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {

                Random r = new Random();
                if ((r.Next(1, 101) <= 30) && (target.Abilities.Name != "せいしんりょく"))
                {
                    target.Flinch = true;
                }

            }
        }
    }


}
