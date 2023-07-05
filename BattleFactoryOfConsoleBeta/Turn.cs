using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.AI;

namespace BattleOfConsole
{
    internal class Turn
    {
        Random r = new Random();
        Type type = new Type();
        Check check = new Check();
        AI ai = new AI();
        Mine mine = new Mine();
        Battle battle = new Battle();
        BattleFactory factory = new BattleFactory();
        Reset reset = new Reset();



        public static int TurnCount { get; set; } = 1;

        public static int wincount = 0;

        public void PickTurn (List<Pokemon> pokemonList,ref List<Pokemon> myteam,ref List<Pokemon> aiteam)
        {
            if (wincount % 7 == 0)
            {
                if (wincount == 0)
                {
                    aiteam = BattleFactory.MakeAITeam(pokemonList);
                    myteam = factory.FirstPick(pokemonList, AI.AITeam);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"おめでとうございます！ {wincount}連勝しました!");
                    Thread.Sleep(1000);
                    Console.WriteLine("7の倍数で手持ちがリセットされます。");
                    Thread.Sleep(1000);
                    AI.AITeam.Clear();
                    AI.AITeam = BattleFactory.MakeAITeam(pokemonList);
                    Mine.MyTeam = factory.FirstPick(pokemonList, aiteam);
                }

            }
            else if (wincount % 7 != 0)
            {
                reset.ResetPokeState(Mine.MyTeam);
                reset.ResetPokeState(AI.AITeam);
                var oldTeam = new List<Pokemon>(AI.AITeam);
                AI.AITeam.Clear();
                AI.AITeam = BattleFactory.SecondMakeAITeam(pokemonList,myteam,oldTeam);

                Console.Clear();
                Console.WriteLine($"現在{wincount}連勝中です。");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine($"つぎのあいては{AI.AITeam[0].Name}や{AI.AITeam[1].Name}をだしてくるみたいです");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine($"てもち:{Mine.MyTeam[0].Name} {Mine.MyTeam[1].Name} {Mine.MyTeam[2].Name}");
                Console.WriteLine($"あいてのてもち:{oldTeam[0].Name} {oldTeam[1].Name} {oldTeam[2].Name}");
                Console.WriteLine();
                Console.WriteLine("ポケモンをこうかんしますか？");
                Console.WriteLine("はい:0 いいえ:1");
                int choicenum = int.Parse(Console.ReadLine());
                while (true)
                {
                    switch (choicenum)
                    {
                        case 0:
                            {
                                factory.SecondPick(myteam, oldTeam);
                                oldTeam.Clear();
                                Console.WriteLine("試合を開始します");
                                break;
                            }
                        case 1:
                            {
                                oldTeam.Clear();
                                Console.WriteLine("試合を開始します");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("無効な入力です。再入力してください。");
                                continue;
                            }
                    }
                    break;
                }
            }
        }

        public void FirstTurn(Pokemon pokemon ,Pokemon target,Field.Fields field,Weather.Weathers weather)
        {
            Thread.Sleep(2000);
            Console.Clear();
            AI.RandomAIName = ai.GetRandomAIName();
            if(AI.RandomAIName == AINames.ネジキ) 
            {
                AI.AiQuote(Mine.MyTeam);
                Console.WriteLine($"バトルファクトリーの{AI.RandomAIName}がしょうぶをしかけてきた！！");
            }
            else 
            {
                Console.WriteLine($"ポケモントレーナーの{AI.RandomAIName}がしょうぶをしかけてきた！！");
            }
            Thread.Sleep(2000);
            Console.WriteLine($"{AI.RandomAIName}は{target.Name}をくりだした!!");
            Thread.Sleep(2000);
            Console.WriteLine($"ゆけっ! {pokemon.Name}!!");
            Thread.Sleep(2000);

            if (check.SpeedCheck(pokemon, target) == 1) 
            {
                pokemon.Abilities.FirstPutEffect(pokemon, target,field,weather);
                target.HaveItem.ItemCounterEffect(target, pokemon);
                pokemon.HaveItem.FirstPutEffect(pokemon,target);
                Thread.Sleep(2000);
                target.Abilities.FirstPutEffect(target, pokemon, field, weather);
                target.HaveItem.ItemCounterEffect(pokemon,target);
                target.HaveItem.FirstPutEffect(target,pokemon);
                Thread.Sleep(2000);
            }
            else 
            {
                target.Abilities.FirstPutEffect(target, pokemon, field, weather);
                target.HaveItem.ItemCounterEffect(pokemon,target);
                target.HaveItem.FirstPutEffect(target, pokemon);
                Thread.Sleep(2000);
                pokemon.Abilities.FirstPutEffect(pokemon, target, field, weather);
                target.HaveItem.ItemCounterEffect(target, pokemon);
                pokemon.HaveItem.FirstPutEffect(pokemon, target);
                Thread.Sleep(2000);
            }

        }

        public Pokemon StanbyTurn(Pokemon pokemon,Pokemon target,List<Pokemon> minepoke,Field.Fields field,Weather.Weathers weather) 
        {
            if (TurnCount > 1)
            {
                Console.Clear();
            }
            while (true)
            {
                //FieldState.CheckField();
                Console.WriteLine("たたかう:0 ポケモン:1 フィールドのかくにん:2 てもちのかくにん:3");
                if (int.TryParse(Console.ReadLine(), out var selectnum))
                {
                    switch (selectnum)
                    {
                        case 0:
                            {
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("どのポケモンと交換する？");
                                battle.PokeTrade(pokemon,target,minepoke,field,weather);
                                break;
                            }
                        case 2:
                            {
                                check.CheckStatsInBattle(pokemon,target,field,weather);
                                Thread.Sleep(2000);
                                continue;
                            }
                        case 3: 
                            {
                                check.CheckStatsMyTeam(Mine.MyTeam);
                                Thread.Sleep(2000);
                                continue;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("無効な入力です。数値を入力してください。");
                    continue;
                }
                return pokemon;
            }
        }


        public void SelectSkillTurn(Pokemon pokemon)
        {
            if (Mine.TradeSkip == false) 
            {
                Console.WriteLine($"{pokemon.Name}はどうする？");
                Console.WriteLine($"{pokemon.Skills[0].Name}:0 {pokemon.Skills[1].Name}:1 {pokemon.Skills[2].Name}:2 {pokemon.Skills[3].Name}:3");

                while (true)
                {
                    var selectedSkillIndex = int.Parse(Console.ReadLine());

                    switch (selectedSkillIndex)
                    {
                        case 0:
                            {
                                pokemon.SelectedSkill = pokemon.Skills[0];
                                break;
                            }
                        case 1:
                            {
                                pokemon.SelectedSkill = pokemon.Skills[1];
                                break;
                            }
                        case 2:
                            {
                                pokemon.SelectedSkill = pokemon.Skills[2];
                                break;
                            }
                        case 3:
                            {
                                pokemon.SelectedSkill = pokemon.Skills[3];
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("無効な選択肢です。再度入力してください。");
                                continue;
                            }
                    }

                    if (pokemon.SelectLockSkill != null && pokemon.SelectLockSkill != pokemon.SelectedSkill)
                    {
                        Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}のえいきょうで{pokemon.SelectLockSkill.Name}しかだせない!");
                        continue;
                    }
                    if (pokemon.HaveItem.Name == "とつげきチョッキ") 
                    {
                        if (pokemon.SelectedSkill.Kinds == Skill.Kind.change) 
                        {
                            Console.WriteLine("とつげきチョッキのえいきょうでへんかわざがだせない!");
                            continue;
                        }
                    }
                    if (pokemon.Taunt == true)
                    {
                        if (pokemon.SelectedSkill.Kinds == Skill.Kind.change)
                        {
                            Console.WriteLine($"{pokemon.Name}はちょうはつされてへんかわざがだせない!");
                            continue;
                        }
                    }
                    break;
                }
            }

        }

        public void EndTurn() 
        {
            Check check = new Check();
            BattleField.MyPokemon.CriticalHitStage = 0;
            BattleField.OppPokemon.CriticalHitStage = 0;
            if (check.SpeedCheck(BattleField.MyPokemon,BattleField.OppPokemon) == 1) 
            {
                BattleField.MyPokemon.HaveItem.EndTurnEffect(BattleField.MyPokemon,BattleField.OppPokemon);
                check.JudgeGameEnd();
                BattleField.OppPokemon.HaveItem.EndTurnEffect(BattleField.OppPokemon,BattleField.MyPokemon);
                check.JudgeGameEnd();
                BattleField.MyPokemon.EndTurnStateEffect(BattleField.MyPokemon,BattleField.OppPokemon);
                check.JudgeGameEnd();
                BattleField.OppPokemon.EndTurnStateEffect(BattleField.OppPokemon,BattleField.MyPokemon);
                check.JudgeGameEnd();
                check.FieldWeatherCheck();
                check.YawnCheck();
            }
            else 
            {
                BattleField.OppPokemon.HaveItem.EndTurnEffect(BattleField.OppPokemon, BattleField.MyPokemon);
                check.JudgeGameEnd();
                BattleField.MyPokemon.HaveItem.EndTurnEffect(BattleField.MyPokemon, BattleField.OppPokemon);
                check.JudgeGameEnd();
                BattleField.OppPokemon.EndTurnStateEffect(BattleField.OppPokemon,BattleField.MyPokemon);
                check.JudgeGameEnd();
                BattleField.MyPokemon.EndTurnStateEffect(BattleField.MyPokemon,BattleField.OppPokemon);
                check.JudgeGameEnd();
                check.FieldWeatherCheck();
                check.YawnCheck();
            }
        }
    }
}

