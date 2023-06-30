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
            ココ,
            シロナ,
            ダイゴ,
            ミクリ,
            ターナー
        }

        public static AINames RandomAIName { get; set; }

        public static bool TradeSkip { get; set; } = false;

        public static bool Flinch { get; set; } = false;

        public static bool Recoil { get; set; } = false;

        public static bool AIStealthRock { get; set; } = false;

        public AINames GetRandomAIName()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, Enum.GetValues(typeof(AINames)).Length);
            AINames randomName = (AINames)randomIndex;
            return randomName;
        }


        public void SelectSkillAi(Pokemon pokemon,Pokemon target) 
        {
            Random r = new Random();
            Type type = new Type();
            Check check = new Check();
            BattleField field = new BattleField();
            
            var oppselectedSkillindex = r.Next(0, 4);
            if(Turn.wincount < 15) 
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
