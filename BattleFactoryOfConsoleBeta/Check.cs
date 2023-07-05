using System.Xml.Linq;
using static BattleOfConsole.Pokemon;

namespace BattleOfConsole
{
    internal class Check
    {
        BattleField field = new BattleField();
        public void CheckIH(Pokemon pokemon)
        {
            Console.WriteLine($"{pokemon.Name}: {pokemon.IH}/{pokemon.InitialIH}");
            if (pokemon.IH == 0) 
            {
                Console.WriteLine($"{pokemon.Name}はたおれた!");
                pokemon.Fainted = true;
            }
        }

        public void CheckStats(Pokemon pokemon,Field.Fields field,Weather.Weathers weather)
        {
            Console.WriteLine($"{pokemon.Name}");
            Console.WriteLine($"HP:{pokemon.IH}/{pokemon.InitialIH}");
            Console.WriteLine($"こうげき:{pokemon.IA} ランク:{pokemon.Arank}");
            Console.WriteLine($"ぼうぎょ:{pokemon.IB} ランク:{pokemon.Brank}");
            Console.WriteLine($"とくこう:{pokemon.IC} ランク:{pokemon.Crank}");
            Console.WriteLine($"とくぼう:{pokemon.ID} ランク:{pokemon.Drank}");
            Console.WriteLine($"すばやさ:{pokemon.IS} ランク:{pokemon.Srank}");
            Console.WriteLine($"わざ１:{pokemon.Skills[0].Name}");
            Console.WriteLine($"わざ２:{pokemon.Skills[1].Name}");
            Console.WriteLine($"わざ３:{pokemon.Skills[2].Name}");
            Console.WriteLine($"わざ４:{pokemon.Skills[3].Name}");
            Console.WriteLine($"もちもの:{pokemon.HaveItem.Name}");
            Console.WriteLine($"とくせい:{pokemon.Abilities.Name}");
            Console.WriteLine($"フィールド:{field}");
            Console.WriteLine($"てんき:{weather}");
            Console.WriteLine();
        }

        public void CheckStatsInBattle(Pokemon pokemon,Pokemon target, Field.Fields field, Weather.Weathers weather)
        {
            Console.WriteLine($"じぶんのポケモン\tあいてのポケモン");
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"{pokemon.Name}\t\t{target.Name}");
            Console.WriteLine($"タイプ1:{pokemon.Type1}\t\tタイプ1:{target.Type1}");
            Console.WriteLine($"タイプ2:{pokemon.Type2}\t\tタイプ2:{target.Type2}");
            Console.WriteLine($"HP:{pokemon.IH}/{pokemon.InitialIH}\t\t{target.IH}/{target.InitialIH}");
            Console.WriteLine($"こうげき:{pokemon.IA} ランク:{pokemon.Arank}\tランク:{target.Arank}");
            Console.WriteLine($"ぼうぎょ:{pokemon.IB} ランク:{pokemon.Brank}\tランク:{target.Brank}");
            Console.WriteLine($"とくこう:{pokemon.IC} ランク:{pokemon.Crank}\tランク:{target.Crank}");
            Console.WriteLine($"とくぼう:{pokemon.ID} ランク:{pokemon.Drank}\tランク:{target.Drank}");
            Console.WriteLine($"すばやさ:{pokemon.IS} ランク:{pokemon.Srank}\tランク:{target.Srank}");
            Console.WriteLine($"じょうたい:{pokemon.State}\t\t{target.State}");
            Console.WriteLine($"わざ１:{pokemon.Skills[0].Name}");
            Console.WriteLine($"わざ２:{pokemon.Skills[1].Name}");
            Console.WriteLine($"わざ３:{pokemon.Skills[2].Name}");
            Console.WriteLine($"わざ４:{pokemon.Skills[3].Name}");
            Console.WriteLine($"もちもの:{pokemon.HaveItem.Name}");
            Console.WriteLine($"とくせい:{pokemon.Abilities.Name}");
            Console.WriteLine($"フィールド:{field}");
            Console.WriteLine($"てんき:{weather}");
            Console.WriteLine();
        }

        public void CheckStatsMyTeam(List<Pokemon> myteam)
        {
            Console.WriteLine($"ポケモン1");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"{myteam[0].Name}");
            Console.WriteLine($"タイプ1:{myteam[0].Type1}");
            Console.WriteLine($"タイプ2:{myteam[0].Type2}");
            Console.WriteLine($"HP:{myteam[0].IH}/{myteam[0].InitialIH}");
            Console.WriteLine($"こうげき:{myteam[0].IA}");
            Console.WriteLine($"ぼうぎょ:{myteam[0].IB}");
            Console.WriteLine($"とくこう:{myteam[0].IC}");
            Console.WriteLine($"とくぼう:{myteam[0].ID}");
            Console.WriteLine($"すばやさ:{myteam[0].IS}");
            Console.WriteLine($"じょうたい:{myteam[0].State}");
            Console.WriteLine($"わざ１:{myteam[0].Skills[0].Name}");
            Console.WriteLine($"わざ２:{myteam[0].Skills[1].Name}");
            Console.WriteLine($"わざ３:{myteam[0].Skills[2].Name}");
            Console.WriteLine($"わざ４:{myteam[0].Skills[3].Name}");
            Console.WriteLine($"もちもの:{myteam[0].HaveItem.Name}");
            Console.WriteLine($"とくせい:{myteam[0].Abilities.Name}");
            Console.WriteLine();
            Console.WriteLine($"ポケモン2");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"{myteam[1].Name}");
            Console.WriteLine($"タイプ1:{myteam[1].Type1}");
            Console.WriteLine($"タイプ2:{myteam[1].Type2}");
            Console.WriteLine($"HP:{myteam[1].IH}/{myteam[1].InitialIH}");
            Console.WriteLine($"こうげき:{myteam[1].IA}");
            Console.WriteLine($"ぼうぎょ:{myteam[1].IB}");
            Console.WriteLine($"とくこう:{myteam[1].IC}");
            Console.WriteLine($"とくぼう:{myteam[1].ID}");
            Console.WriteLine($"すばやさ:{myteam[1].IS}");
            Console.WriteLine($"じょうたい:{myteam[1].State}");
            Console.WriteLine($"わざ１:{myteam[1].Skills[0].Name}");
            Console.WriteLine($"わざ２:{myteam[1].Skills[1].Name}");
            Console.WriteLine($"わざ３:{myteam[1].Skills[2].Name}");
            Console.WriteLine($"わざ４:{myteam[1].Skills[3].Name}");
            Console.WriteLine($"もちもの:{myteam[1].HaveItem.Name}");
            Console.WriteLine($"とくせい:{myteam[1].Abilities.Name}");
            Console.WriteLine();
            Console.WriteLine($"ポケモン3");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"{myteam[2].Name}");
            Console.WriteLine($"タイプ1:{myteam[2].Type1}");
            Console.WriteLine($"タイプ2:{myteam[2].Type2}");
            Console.WriteLine($"HP:{myteam[2].IH}/{myteam[2].InitialIH}");
            Console.WriteLine($"こうげき:{myteam[2].IA}");
            Console.WriteLine($"ぼうぎょ:{myteam[2].IB}");
            Console.WriteLine($"とくこう:{myteam[2].IC}");
            Console.WriteLine($"とくぼう:{myteam[2].ID}");
            Console.WriteLine($"すばやさ:{myteam[2].IS}");
            Console.WriteLine($"じょうたい:{myteam[2].State}");
            Console.WriteLine($"わざ１:{myteam[2].Skills[0].Name}");
            Console.WriteLine($"わざ２:{myteam[2].Skills[1].Name}");
            Console.WriteLine($"わざ３:{myteam[2].Skills[2].Name}");
            Console.WriteLine($"わざ４:{myteam[2].Skills[3].Name}");
            Console.WriteLine($"もちもの:{myteam[2].HaveItem.Name}");
            Console.WriteLine($"とくせい:{myteam[2].Abilities.Name}");
            Console.WriteLine();
        }


        public void CheckAIStats(Pokemon pokemon, Field.Fields field, Weather.Weathers weather)
        {
            Console.WriteLine($"{pokemon.Name}");
            Console.WriteLine($"HP:{pokemon.IH}/{pokemon.InitialIH}");
            Console.WriteLine($"こうげき:{pokemon.IA} ランク:{pokemon.Arank}");
            Console.WriteLine($"ぼうぎょ:{pokemon.IB} ランク:{pokemon.Brank}");
            Console.WriteLine($"とくこう:{pokemon.IC} ランク:{pokemon.Crank}");
            Console.WriteLine($"とくぼう:{pokemon.ID} ランク:{pokemon.Drank}");
            Console.WriteLine($"すばやさ:{pokemon.IS} ランク:{pokemon.Srank}");
            Console.WriteLine($"わざ１:{pokemon.Skills[0].Name}");
            Console.WriteLine($"わざ２:{pokemon.Skills[1].Name}");
            Console.WriteLine($"わざ３:{pokemon.Skills[2].Name}");
            Console.WriteLine($"わざ４:{pokemon.Skills[3].Name}");
            Console.WriteLine($"もちもの:{pokemon.HaveItem.Name}");
            Console.WriteLine($"とくせい:{pokemon.Abilities.Name}");
            Console.WriteLine($"フィールド:{field}");
            Console.WriteLine($"てんき:{weather}");
            Console.WriteLine();
        }

        public int SpeedCheck(Pokemon mypoke, Pokemon target)
        {
            Random r = new Random();
            var myPokeS = mypoke.IS;
            var tarPokeS = target.IS;

            if (mypoke.State == Pokemon.Statements.Paralyze)
            {
                myPokeS = myPokeS * 1 / 2;
            }
            if (target.State == Pokemon.Statements.Paralyze)
            {
                tarPokeS = tarPokeS * 1 / 2;
            }
            if (mypoke.HaveItem != null)
            {
                if (mypoke.HaveItem.Name == "こだわりスカーフ")
                {
                    myPokeS *= 2;
                }
            }
            if (target.HaveItem != null)
            {
                if (target.HaveItem.Name == "こだわりスカーフ")
                {
                    tarPokeS *= 2;
                }
            }
            if((mypoke.Abilities.Name=="すなかき")&&(Weather.CurrentWeather == Weather.Weathers.SandStorm)) 
            {
                myPokeS *= 2;
            }
            if ((target.Abilities.Name == "すなかき") && (Weather.CurrentWeather == Weather.Weathers.SandStorm))
            {
                tarPokeS *= 2;
            }
            if ((mypoke.Abilities.Name == "すいすい") && (Weather.CurrentWeather == Weather.Weathers.Rain))
            {
                myPokeS *= 2;
            }
            if ((target.Abilities.Name == "すいすい") && (Weather.CurrentWeather == Weather.Weathers.Rain))
            {
                tarPokeS *= 2;
            }

            if (myPokeS > tarPokeS)
            {
                if((mypoke.SelectedSkill != null) && (target.SelectedSkill != null))
                {
                    if (mypoke.SelectedSkill.Priority < target.SelectedSkill.Priority)
                    {
                        return 2;
                    }
                    return 1;
                } 

            }
            else if (myPokeS < tarPokeS)
            {
                if ((mypoke.SelectedSkill != null) && (target.SelectedSkill != null)) 
                {
                    if (mypoke.SelectedSkill.Priority > target.SelectedSkill.Priority)
                    {
                        return 1;
                    }
                    return 2;
                }
            }
            else if (myPokeS == tarPokeS)
            {
                if ((mypoke.SelectedSkill != null) && (target.SelectedSkill != null))
                {
                    if (mypoke.SelectedSkill.Priority < target.SelectedSkill.Priority)
                    {
                        return 2;
                    }
                    else if (mypoke.SelectedSkill.Priority > target.SelectedSkill.Priority)
                    {
                        return 1;
                    }
                    return r.Next(1, 3);
                }   
            }
            return 0;
        }

        public void BurnCheck(Pokemon pokemon) 
        {
            if(pokemon.State == Statements.Burn) 
            {
                pokemon.BurnGainIA = 0.5;
            }
        }

        public void CanMoveCheck(Pokemon pokemon)
        {
            Random r = new Random();
            if (pokemon.State == Statements.Sleep)
            {
                pokemon.SleepCount--;
                if (pokemon.SleepCount <= 0)
                {
                    pokemon.State = Statements.None;
                    Console.WriteLine($"{pokemon.Name}はめをさました!");
                    pokemon.Flinch = false;
                    pokemon.Recoil = false;
                }
                else
                {
                    Console.WriteLine($"{pokemon.Name}はぐうぐうねむっている");
                    pokemon.TurnSkip = true;
                    pokemon.Flinch = false;
                    pokemon.Recoil = false;
                }
            }
            else if (pokemon.State == Statements.Paralyze)
            {
                if (r.Next(1, 101) <= 33)
                {
                    Console.WriteLine($"{pokemon.Name}はしびれてうごけない!");
                    pokemon.TurnSkip = true;
                    pokemon.Flinch = false;
                    pokemon.Recoil = false;
                }
            }
            else if (pokemon.State == Statements.Freeze)
            {
                if (r.Next(1, 101) <= 20)
                {
                    Console.WriteLine($"{pokemon.Name}はこおってしまってうごけない!");
                    pokemon.TurnSkip = true;
                    pokemon.Flinch = false;
                    pokemon.Recoil = false;
                }
                else 
                {
                    Console.WriteLine($"{pokemon.Name}のこおりがとけた!");
                    pokemon.State = Statements.None;
                }
            }

            else if (pokemon.Recoil == true)
            {
                Console.WriteLine($"{pokemon.Name}はこうげきのはんどうでうごけない!");
                pokemon.Recoil = false;
                pokemon.Flinch = false;
                pokemon.TurnSkip = true;
            }
            else if (pokemon.Flinch == true)
            {
                Console.WriteLine($"{pokemon.Name}はひるんでうごけない!");
                pokemon.Flinch = false;
                pokemon.TurnSkip = true;
            }
            if ((pokemon.Taunt == true) && (pokemon.SelectedSkill.Kinds == Skill.Kind.change))
            {
                Console.WriteLine($"{pokemon.Name}はちょうはつされてわざがだせない!");
                pokemon.TurnSkip = true;
            }
            if ((pokemon.Confusion == true) && (pokemon.TurnSkip == false))
            {
                pokemon.ConfusionCount--;
                if (pokemon.ConfusionCount <= 0)
                {
                    Console.WriteLine($"{pokemon.Name}のこんらんがとけた!");
                    pokemon.Confusion = false;
                }
                else
                {
                    Console.WriteLine($"{pokemon.Name}はこんらんしている!");
                    Thread.Sleep(1000);
                    if (r.Next(1, 101) <= 33)
                    {
                        var damegeRandom = Math.Round(r.NextDouble() * 0.15 + 0.85, 2);
                        Console.WriteLine($"{pokemon.Name}はわけもわからずじぶんをこうげきした!");
                        double damage = (((2 * 100 / 5 + 2) * 40 * pokemon.IA / pokemon.IB) / 50 + 2) * damegeRandom;
                        pokemon.IH -= (int)damage;
                        CheckIH(pokemon);
                        pokemon.TurnSkip = true;
                    }
                }
            }
        }

        public void CheckRankState(Pokemon pokemon)
        {
            if (pokemon.Arank < 0)
            {
                pokemon.IA = pokemon.InitialIA * 2 / (2 + Math.Abs(pokemon.Arank));
            }
            else if (pokemon.Arank > 0)
            {
                pokemon.IA = pokemon.InitialIA * (2 + pokemon.Arank) / 2;
            }
            if (pokemon.Brank < 0)
            {
                pokemon.IB = pokemon.InitialIB * 2 / (2 + Math.Abs(pokemon.Brank));
            }
            else if (pokemon.Brank > 0)
            {
                pokemon.IB = pokemon.InitialIB * (2 + pokemon.Brank) / 2;
            }
            if (pokemon.Crank < 0)
            {
                pokemon.IC = pokemon.InitialIC * 2 / (2 + Math.Abs(pokemon.Crank));
            }
            else if (pokemon.Crank > 0)
            {
                pokemon.IC = pokemon.InitialIC * (2 + pokemon.Crank) / 2;
            }
            if (pokemon.Drank < 0)
            {
                pokemon.ID = pokemon.InitialID * 2 / (2 + Math.Abs(pokemon.Drank));
            }
            else if (pokemon.Drank > 0)
            {
                pokemon.ID = pokemon.InitialID * (2 + pokemon.Drank) / 2;
            }
            if (pokemon.Srank < 0)
            {
                pokemon.IS = pokemon.InitialIS * 2 / (2 + Math.Abs(pokemon.Srank));
            }
            else if (pokemon.Srank > 0)
            {
                pokemon.IS = pokemon.InitialIS * (2 + pokemon.Srank) / 2;
            }
        }

        public void FieldWeatherCheck()
        {
            Check check = new Check();
            if(Weather.CurrentWeather != Weather.Weathers.None) 
            {
                Weather.WeatherCount++;
            }
            if (Weather.WeatherCount > 5)
            {
                Console.WriteLine("もとのてんきにもどった");
                Weather.CurrentWeather = Weather.Weathers.None;
                Weather.WeatherCount = 0;
            }
            if ((Weather.CurrentWeather != Weather.Weathers.None) && (Weather.WeatherCount <= 5))
            {
                Weather.WeatherCount++;
            }
            if (Weather.CurrentWeather == Weather.Weathers.Sunny)
            {
                Console.WriteLine("ひざしがつよい");
            }
            else if (Weather.CurrentWeather == Weather.Weathers.Rain)
            {
                Console.WriteLine("あめがふりつづいている");
            }
            else if (Weather.CurrentWeather == Weather.Weathers.SandStorm)
            {
                Console.WriteLine("すなあらしがふきあれる");
                if (check.SpeedCheck(BattleField.MyPokemon, BattleField.OppPokemon) == 1)
                {
                    if ((BattleField.MyPokemon.Type1 != Type.Types.Metal) && (BattleField.MyPokemon.Type1 != Type.Types.Rock) && (BattleField.MyPokemon.Type1 != Type.Types.Grand) && (BattleField.MyPokemon.Type2 != Type.Types.Metal) && (BattleField.MyPokemon.Type2 != Type.Types.Rock) && (BattleField.MyPokemon.Type2 != Type.Types.Grand))
                    {
                        BattleField.MyPokemon.IH -= BattleField.MyPokemon.InitialIH / 16;
                        Console.WriteLine($"{BattleField.MyPokemon.Name}はすなあらしのダメージをうけた!");
                        check.CheckIH(BattleField.MyPokemon);
                        BattleField.MyPokemon.HaveItem.AfterDamageEffect(BattleField.MyPokemon,BattleField.OppPokemon,0);
                        check.JudgeGameEnd();
                    }
                    if ((BattleField.OppPokemon.Type1 != Type.Types.Metal) && (BattleField.OppPokemon.Type1 != Type.Types.Rock) && (BattleField.OppPokemon.Type1 != Type.Types.Grand) && (BattleField.OppPokemon.Type2 != Type.Types.Metal) && (BattleField.OppPokemon.Type2 != Type.Types.Rock) && (BattleField.OppPokemon.Type2 != Type.Types.Grand))
                    {
                        BattleField.OppPokemon.IH -= BattleField.OppPokemon.InitialIH / 16;
                        Console.WriteLine($"{BattleField.OppPokemon.Name}はすなあらしのダメージをうけた!");
                        check.CheckIH(BattleField.OppPokemon);
                        BattleField.OppPokemon.HaveItem.AfterDamageEffect(BattleField.OppPokemon, BattleField.MyPokemon, 0);
                        check.JudgeGameEnd();
                    }
                }
                else
                {
                    if ((BattleField.OppPokemon.Type1 != Type.Types.Metal) && (BattleField.OppPokemon.Type1 != Type.Types.Rock) && (BattleField.OppPokemon.Type1 != Type.Types.Grand) && (BattleField.OppPokemon.Type2 != Type.Types.Metal) && (BattleField.OppPokemon.Type2 != Type.Types.Rock) && (BattleField.OppPokemon.Type2 != Type.Types.Grand))
                    {
                        BattleField.OppPokemon.IH -= BattleField.OppPokemon.InitialIH / 16;
                        Console.WriteLine($"{BattleField.OppPokemon.Name}はすなあらしのダメージをうけた!");
                        check.CheckIH(BattleField.OppPokemon);
                        BattleField.OppPokemon.HaveItem.AfterDamageEffect(BattleField.OppPokemon, BattleField.MyPokemon, 0);
                        check.JudgeGameEnd();
                    }
                    if ((BattleField.MyPokemon.Type1 != Type.Types.Metal) && (BattleField.MyPokemon.Type1 != Type.Types.Rock) && (BattleField.MyPokemon.Type1 != Type.Types.Grand) && (BattleField.MyPokemon.Type2 != Type.Types.Metal) && (BattleField.MyPokemon.Type2 != Type.Types.Rock) && (BattleField.MyPokemon.Type2 != Type.Types.Grand))
                    {
                        BattleField.MyPokemon.IH -= BattleField.MyPokemon.InitialIH / 16;
                        Console.WriteLine($"{BattleField.MyPokemon.Name}はすなあらしのダメージをうけた!");
                        check.CheckIH(BattleField.MyPokemon);
                        BattleField.MyPokemon.HaveItem.AfterDamageEffect(BattleField.MyPokemon, BattleField.OppPokemon, 0);
                        check.JudgeGameEnd();
                    }
                }
                

            }
            else if (Weather.CurrentWeather == Weather.Weathers.Snow)
            {
                Console.WriteLine("ゆきがふりつづいている");
            }

            if(Field.CurrentField != Field.Fields.None) 
            {
                Field.FieldCount++;
            }
            if (Field.FieldCount > 5)
            {
                Console.WriteLine("もとのフィールドにもどった");
                Field.CurrentField = Field.Fields.None;
                Field.FieldCount = 0;
            }

            if(Mine.MineLightScreen == true) 
            {
                Mine.LightScreenCounter--;
                if (Mine.LightScreenCounter == 0)
                {
                    Console.WriteLine("みかたのひかりのかべのこうかがきれた");
                    Mine.MineLightScreen = false;
                }
            }
            else if(AI.AILightScreen == true) 
            {
                AI.LightScreenCounter--;
                if(AI.LightScreenCounter == 0) 
                {
                    Console.WriteLine("あいてのひかりのかべのこうかがきれた");
                    AI.AILightScreen = false;
                }
            }

            if (Mine.MineReflect == true)
            {
                Mine.ReflectCounter--;
                if (Mine.ReflectCounter == 0)
                {
                    Console.WriteLine("みかたのリフレクターのこうかがきれた");
                    Mine.MineReflect = false;
                }
            }
            else if (AI.AIReflect == true)
            {
                AI.ReflectCounter--;
                if (AI.ReflectCounter == 0)
                {
                    Console.WriteLine("あいてのリフレクターのこうかがきれた");
                    AI.AIReflect = false;
                }
            }
        }

        public void YawnCheck() 
        {
            Random r = new Random();
            if(BattleField.MyPokemon.YawnCount != -1) 
            {
                if((BattleField.MyPokemon.YawnCount + 1 == Turn.TurnCount) && (BattleField.MyPokemon.State == Statements.None))
                {
                    Console.WriteLine($"{BattleField.MyPokemon.Name}はねむりにおちた!");
                    BattleField.MyPokemon.State = Statements.Sleep;
                    BattleField.MyPokemon.SleepCount = r.Next(2, 6);
                    BattleField.MyPokemon.YawnCount = -1;
                }
            }
            Thread.Sleep(1000);
            if((BattleField.OppPokemon.YawnCount != -1) && (BattleField.OppPokemon.State == Statements.None))
            {
                if(BattleField.OppPokemon.YawnCount + 1 == Turn.TurnCount) 
                {
                    Console.WriteLine($"{BattleField.OppPokemon.Name}はねむりにおちた!");
                    BattleField.OppPokemon.State = Statements.Sleep;
                    BattleField.OppPokemon.SleepCount = r.Next(2, 6);
                    BattleField.OppPokemon.YawnCount = -1;
                }
            }
        }

        public bool CheckCriticalHit(Pokemon pokemon) 
        {
            Random r = new Random();
            int CriticalHitCheck = r.Next(1, 25);
            if (pokemon.CriticalHitStage == 3)
            {
                if (CriticalHitCheck <= 24)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (pokemon.CriticalHitStage == 2)
            {
                if (CriticalHitCheck <= 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (pokemon.CriticalHitStage == 1) 
            {
                if (CriticalHitCheck <= 8)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else 
            {
                if (CriticalHitCheck <= 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool AllTeamPokemonFainted(List<Pokemon> team)
        {
            foreach (var pokemon in team)
            {
                if (pokemon.IH > 0)
                {
                    return false;
                }
            }

            return true;
        }

        public void JudgeGameEnd() 
        {
            Check check = new Check();
            Battle battle = new Battle();
            if (BattleField.OppPokemon.Fainted == true)
            {
                if (check.AllTeamPokemonFainted(AI.AITeam) == true)
                {
                    battle.OppGameOver = true;
                }
                else
                {
                    battle.OppPokeTrade(BattleField.OppPokemon, BattleField.MyPokemon, Field.CurrentField, Weather.CurrentWeather);
                }
            }
            if (BattleField.MyPokemon.Fainted == true)
            {
                if (check.AllTeamPokemonFainted(Mine.MyTeam) == true)
                {
                    battle.MyGameOver = true;
                }
                else
                {
                    battle.PokeTrade(BattleField.MyPokemon, BattleField.OppPokemon, Mine.MyTeam, Field.CurrentField, Weather.CurrentWeather);
                }
            }
        }
    }
}
