using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole
{
    internal class AI
    {
        public static List<Pokemon> AITeam = new List<Pokemon>();
        public bool StealthRock { get; set; } = false;

        public AINames AiName { get; set; }

        public enum AINames 
        {
            カナタ ,
            リョウ ,
            アスカ ,
            フブキ ,
            リョウイチ,
            ナナミ,
            ソウセキ,
            ジョン,
            タロウ,
            ユーリ,
            アクア,
            ハルカ,
            ユウキ,
            アイリス,
            レッド,
            グリーン,
            ブルー,
            ココ,
            シロナ,
            ダイゴ,
            ミクリ,
            ターナー,
            ネジキ,
        }

        public static AINames RandomAIName { get; set; }

        public static bool TradeSkip { get; set; } = false;

        public static bool Flinch { get; set; } = false;

        public static bool Recoil { get; set; } = false;

        public static bool AIStealthRock { get; set; } = false;

        public static bool AILightScreen { get; set; } = false;

        public static int LightScreenCounter { get; set; } = 0;

        public static bool AIReflect { get; set; } = false;

        public static int ReflectCounter { get; set; } = 0;

        public AINames GetRandomAIName()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, Enum.GetValues(typeof(AINames)).Length);
            AINames randomName = (AINames)randomIndex;
            if(((Turn.wincount == 6) || (Turn.wincount == 13)) && (randomName == AINames.ネジキ)) 
            {
                randomName = (AINames)randomIndex - random.Next(1, 10);
            }
            else if((Turn.wincount == 6) || (Turn.wincount == 13)) 
            {
                randomName = AINames.ネジキ;
            }
            return randomName;
        }

        public static void AiQuote(List<Pokemon> pokemonlist) 
        {
            Random r = new Random();
            Console.WriteLine("ジーーーーーー!");
            Thread.Sleep(2000);
            Console.WriteLine("あ　きにしないで　ください");
            Thread.Sleep(2000);
            Console.WriteLine("ぼくが　つかっているのは");
            Thread.Sleep(2000);
            Console.WriteLine("ちょうさ・ぶんせきマシン　ですから");
            Thread.Sleep(2000);
            Console.WriteLine("なるほど!");
            Thread.Sleep(2000);
            Console.WriteLine("きみが　レンタルしたのは");
            Thread.Sleep(2000);
            Console.WriteLine($"{pokemonlist[0].Name} {pokemonlist[1].Name} {pokemonlist[2].Name}");
            Thread.Sleep(2000);
            Console.WriteLine("なるほど　いいくみあわせだな～");
            Thread.Sleep(2000);
            Console.WriteLine("むー　そーだなー");
            Thread.Sleep(2000);
            Console.WriteLine($"{r.Next(1,100)}パーセント　ってトコ?");
            Thread.Sleep(2000);
            Console.WriteLine("あ、いまのすうじは　きにしないで!");
            Thread.Sleep(2000);
            Console.WriteLine("んじゃ　いきまーす!!");
            Thread.Sleep(2000);
            Console.Clear();
        }


        public void SelectSkillAi(Pokemon pokemon,Pokemon target) 
        {
            Random r = new Random();
            Type type = new Type();
            
            var oppselectedSkillindex = r.Next(0, 4);
            if((Turn.wincount < 15) || (RandomAIName != AINames.ネジキ))
            {
                while (true)
                {
                    if (pokemon.SelectLockSkill != null)
                    {
                        pokemon.SelectedSkill = pokemon.SelectLockSkill;
                    }
                    else
                    {
                        switch (oppselectedSkillindex)
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
                        }
                    }

                    if (pokemon.HaveItem.Name == "とつげきチョッキ")
                    {
                        if (pokemon.SelectedSkill.Kinds == Skill.Kind.change)
                        {
                            continue;
                        }
                    }

                    if(pokemon.Taunt == true) 
                    {
                        if(pokemon.SelectedSkill.Kinds == Skill.Kind.change) 
                        {
                            continue;
                        }
                    }

                    break;
                }
            }
            else 
            {
                while (true)
                {
                    if (pokemon.SelectLockSkill != null)
                    {
                        pokemon.SelectedSkill = pokemon.SelectLockSkill;
                    }
                    else
                    {
                        oppselectedSkillindex = r.Next(0, 4);
                        switch (oppselectedSkillindex)
                        {
                            case 0:
                                {
                                    type.TypeEffect(target, pokemon.Skills[0]);
                                    if(type.EffectivCounter == 0) 
                                    {
                                        continue;
                                    }
                                    pokemon.SelectedSkill = pokemon.Skills[0];
                                    break;
                                }
                            case 1:
                                {
                                    type.TypeEffect(target, pokemon.Skills[1]);
                                    if (type.EffectivCounter == 0)
                                    {
                                        continue;
                                    }
                                    pokemon.SelectedSkill = pokemon.Skills[1];
                                    break;
                                }
                            case 2:
                                {
                                    type.TypeEffect(target, pokemon.Skills[2]);
                                    if (type.EffectivCounter == 0)
                                    {
                                        continue;
                                    }
                                    pokemon.SelectedSkill = pokemon.Skills[2];
                                    break;
                                }
                            case 3:
                                {
                                    type.TypeEffect(target, pokemon.Skills[3]);
                                    if (type.EffectivCounter == 0)
                                    {
                                        continue;
                                    }
                                    pokemon.SelectedSkill = pokemon.Skills[3];
                                    break;
                                }
                        }
                    }

                    if (pokemon.HaveItem.Name == "とつげきチョッキ")
                    {
                        if (pokemon.SelectedSkill.Kinds == Skill.Kind.change)
                        {
                            continue;
                        }
                    }

                    break;
                }
            }
            
            
        }
    }
}
