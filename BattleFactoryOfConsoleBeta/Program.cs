//using BattleOfConsole.Fields;

namespace BattleOfConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon roaringMoon1 = new RoaringMoon1();
            Pokemon lucario1 = new Lucario1();
            Pokemon tapukoko1 = new Tapukoko1();
            Pokemon ceruledge1 = new Ceruledge1();
            Pokemon garchomp1 = new Garchomp1();
            Pokemon metagross1 = new Metagross1();
            Pokemon sylveon1 = new Sylveon1();
            Pokemon tyranitar1 = new Tyranitar1();
            Pokemon gyarados1 = new Gyarados1();
            Pokemon venusaur1 = new Venusaur1();
            Pokemon gastrodon1 = new Gastrodon1();
            Pokemon staraptor1 = new Staraptor1();
            Pokemon salamence1 = new Salamence1();
            Pokemon politoed1 = new Politoed1();
            Pokemon torkoal1 = new Torkoal1();
            Pokemon quaquaval1 = new Quaquaval1();
            Pokemon pikachu1 = new Pikachu1();
            Pokemon armarouge1 = new Armarouge1();
            Pokemon ironvaliant1 = new IronValiant1();
            Pokemon excadrill1 = new Excadrill1();
            Pokemon heatran1 = new Heatran1();
            Pokemon kingdra1 = new Kingdra1();


            Battle battle = new Battle();
            Turn turn = new Turn();
            AI aI = new AI();
            Check check = new Check();
            Reset reset = new Reset();

            List<Pokemon> pokemonList = new List<Pokemon>()
            {
                roaringMoon1 , lucario1 , tapukoko1 , ceruledge1 , garchomp1 , metagross1 , sylveon1 , tyranitar1 ,gyarados1, venusaur1 , gastrodon1 , staraptor1, salamence1 , politoed1 , torkoal1 , quaquaval1, pikachu1 , armarouge1 ,ironvaliant1, excadrill1, heatran1 , kingdra1 ,
            };

            while (true)
            {
                turn.PickTurn(pokemonList, ref Mine.MyTeam, ref AI.AITeam);
                BattleField.MyPokemon = Mine.MyTeam[0];
                BattleField.OppPokemon = AI.AITeam[0];
                turn.FirstTurn(BattleField.MyPokemon, BattleField.OppPokemon, Field.CurrentField, Weather.CurrentWeather);
                Mine.TradeSkip = false;
                AI.TradeSkip = false;

                while (true)
                {
                    reset.InitialRankReset();
                    turn.StanbyTurn(BattleField.MyPokemon, BattleField.OppPokemon, Mine.MyTeam, Field.CurrentField, Weather.CurrentWeather);
                    if (Mine.TradeSkip == false)
                    {
                        turn.SelectSkillTurn(BattleField.MyPokemon);
                    }
                    aI.SelectSkillAi(BattleField.OppPokemon,BattleField.MyPokemon);
                    Weather.WeatherStateEffect(BattleField.MyPokemon, Weather.CurrentWeather);
                    Weather.WeatherStateEffect(BattleField.OppPokemon, Weather.CurrentWeather);

                    if (check.SpeedCheck(BattleField.MyPokemon, BattleField.OppPokemon) == 1)
                    {
                        check.CanMoveCheck(BattleField.MyPokemon);
                        if((!Mine.TradeSkip) && (!BattleField.MyPokemon.TurnSkip)) 
                        {
                            battle.AttackPokemon(BattleField.MyPokemon, BattleField.OppPokemon, BattleField.MyPokemon.SelectedSkill, Field.CurrentField, Weather.CurrentWeather);
                            if (battle.OppGameOver == true)
                            {
                                break;
                            }
                            if (battle.MyGameOver == true)
                            {
                                break;
                            }
                        }
                        Thread.Sleep(1000);
                        check.CanMoveCheck(BattleField.OppPokemon);
                        if((!AI.TradeSkip) && (!BattleField.OppPokemon.TurnSkip)) 
                        {
                            battle.AttackPokemon(BattleField.OppPokemon, BattleField.MyPokemon, BattleField.OppPokemon.SelectedSkill, Field.CurrentField, Weather.CurrentWeather);
                            if (battle.MyGameOver == true)
                            {
                                break;
                            }
                            if (battle.OppGameOver == true)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        check.CanMoveCheck(BattleField.OppPokemon);
                        if((!AI.TradeSkip) && (!BattleField.OppPokemon.TurnSkip)) 
                        {
                            battle.AttackPokemon(BattleField.OppPokemon, BattleField.MyPokemon, BattleField.OppPokemon.SelectedSkill, Field.CurrentField, Weather.CurrentWeather);
                            if (battle.MyGameOver == true)
                            {
                                break;
                            }
                            if (battle.OppGameOver == true)
                            {
                                break;
                            }
                        }

                        Thread.Sleep(1000);
                        check.CanMoveCheck(BattleField.MyPokemon);
                        if((!Mine.TradeSkip) && (!BattleField.MyPokemon.TurnSkip)) 
                        {
                            battle.AttackPokemon(BattleField.MyPokemon, BattleField.OppPokemon, BattleField.MyPokemon.SelectedSkill, Field.CurrentField, Weather.CurrentWeather);
                            if (battle.OppGameOver == true)
                            {
                                break;
                            }
                            if (battle.MyGameOver == true)
                            {
                                break;
                            }
                        }
                    }

                    turn.EndTurn();
                    if (battle.OppGameOver == true)
                    {
                        break;
                    }
                    if (battle.MyGameOver == true)
                    {
                        break;
                    }
                    Thread.Sleep(2000);
                    reset.ResetBool();
                    Turn.TurnCount++;
                    Console.Clear();


                }
                if (battle.MyGameOver == true)
                {
                    break;
                }
                reset.FieldReset();
                battle.MyGameOver = false;
                battle.OppGameOver = false;
                Thread.Sleep(1000);
                Console.WriteLine($"{AI.RandomAIName}とのしょうぶにかった!");
                Thread.Sleep(1000);
                Turn.wincount += 1;


            }
            Console.WriteLine($"{AI.RandomAIName}とのしょうぶにまけた。\n {Turn.wincount}連勝です。お疲れさまでした。");
        }
    }
}