using BattleOfConsole.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole
{
    internal class Type
    {
        public Types PokeType { get; set; }

        public enum Types
        {
            Fire,
            Water,
            Leaf,
            Fly,
            Dragon,
            Metal,
            Elec,
            Nomal,
            Ice,
            Grand,
            Rock,
            Gohst,
            Fairy,
            Bug,
            Dark,
            Psy,
            Fight,
            Poison,
            None
        }

        public double EffectivCounter { get; set; }

        public static double SkillTypeCollect { get; set; } = 1;

        public void TypeEffect(Pokemon target,Skill selectedSkill)
        {
            EffectivCounter = 1;
            var checkTypes = new List<Types>() { target.Type1, target.Type2 };
            foreach (var CheckType in checkTypes)
            {
                if (CheckType == Types.None)
                {
                    break;
                }
                else if (selectedSkill.SkillType == Types.Nomal)
                {
                    if ((CheckType == Types.Rock) || (CheckType == Types.Metal))
                    {
                        EffectivCounter /= 2;
                    }
                    else if (CheckType == Types.Gohst)
                    {
                        EffectivCounter = 0;
                    }
                }
                else if (selectedSkill.SkillType == Types.Water)
                {
                    if ((CheckType == Types.Water) || (CheckType == Types.Leaf) || (CheckType == Types.Dragon))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Fire) || (CheckType == Types.Grand) || (CheckType == Types.Rock))
                    {
                        EffectivCounter *= 2;
                    }
                }
                else if ((selectedSkill.SkillType == Types.Fire))
                {
                    if ((CheckType == Types.Fire) || (CheckType == Types.Water) || (CheckType == Types.Rock) || (CheckType == Types.Dragon))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Leaf) || (CheckType == Types.Ice) || (CheckType == Types.Bug) || (CheckType == Types.Metal))
                    {
                        EffectivCounter *= 2;
                    }
                }
                else if (selectedSkill.SkillType  == Types.Leaf)
                {
                    if ((CheckType == Types.Leaf) || (CheckType == Types.Fire) || (CheckType == Types.Poison) || (CheckType == Types.Fly) || (CheckType == Types.Bug) || (CheckType == Types.Dragon) || (CheckType == Types.Metal))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Water) || (CheckType == Types.Grand) || (CheckType == Types.Rock))
                    {
                        EffectivCounter *= 2;
                    }
                }
                else if (selectedSkill.SkillType == Types.Elec)
                {
                    if ((CheckType == Types.Elec) || (CheckType == Types.Leaf) || (CheckType == Types.Dragon))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Water) || (CheckType == Types.Fly))
                    {
                        EffectivCounter *= 2;
                    }
                    else if (CheckType == Types.Grand)
                    {
                        EffectivCounter = 0;
                    }
                }
                else if (selectedSkill.SkillType == Types.Ice)
                {
                    if ((CheckType == Types.Fire) || (CheckType == Types.Water) || (CheckType == Types.Ice) || (CheckType == Types.Metal))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Leaf) || (CheckType == Types.Grand) || (CheckType == Types.Fly) || (CheckType == Types.Dragon))
                    {
                        EffectivCounter *= 2;
                    }
                }
                else if (selectedSkill.SkillType == Types.Fight)
                {
                    if ((CheckType == Types.Poison) || (CheckType == Types.Fly) || (CheckType == Types.Psy) || (CheckType == Types.Bug) || (CheckType == Types.Fairy))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Nomal) || (CheckType == Types.Ice) || (CheckType == Types.Rock) || (CheckType == Types.Dark) || (CheckType == Types.Metal))
                    {
                        EffectivCounter *= 2;
                    }
                    else if (CheckType == Types.Gohst)
                    {
                        EffectivCounter = 0;
                    }
                }
                else if (selectedSkill.SkillType == Types.Poison)
                {
                    if ((CheckType == Types.Poison) || (CheckType == Types.Grand) || (CheckType == Types.Rock) || (CheckType == Types.Gohst))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Leaf) || (CheckType == Types.Fairy))
                    {
                        EffectivCounter *= 2;
                    }
                    else if (CheckType == Types.Metal)
                    {
                        EffectivCounter = 0;
                    }
                }
                else if (selectedSkill.SkillType == Types.Grand)
                {
                    if ((CheckType == Types.Leaf) || (CheckType == Types.Bug))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Fire) || (CheckType == Types.Elec) || (CheckType == Types.Poison) || (CheckType == Types.Rock) || (CheckType == Types.Metal))
                    {
                        EffectivCounter *= 2;
                    }
                    else if (CheckType == Types.Fly)
                    {
                        EffectivCounter = 0;
                    }
                }
                else if (selectedSkill.SkillType == Types.Fly)
                {
                    if ((CheckType == Types.Elec) || (CheckType == Types.Rock) || (CheckType == Types.Metal))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Leaf) || (CheckType == Types.Fight) || (CheckType == Types.Bug))
                    {
                        EffectivCounter *= 2;
                    }
                }
                else if (selectedSkill.SkillType == Types.Psy)
                {
                    if ((CheckType == Types.Psy) || (CheckType == Types.Metal))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Fight) || (CheckType == Types.Poison))
                    {
                        EffectivCounter *= 2;
                    }
                    else if (CheckType == Types.Dark)
                    {
                        EffectivCounter = 0;
                    }
                }
                else if (selectedSkill.SkillType == Types.Bug)
                {
                    if ((CheckType == Types.Fire) || (CheckType == Types.Fight) || (CheckType == Types.Poison) || (CheckType == Types.Fly) || (CheckType == Types.Metal) || (CheckType == Types.Fairy))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Leaf) || (CheckType == Types.Psy) || (CheckType == Types.Dark))
                    {
                        EffectivCounter *= 2;
                    }
                }
                else if (selectedSkill.SkillType == Types.Rock)
                {
                    if ((CheckType == Types.Fight) || (CheckType == Types.Grand) || (CheckType == Types.Metal))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Fire) || (CheckType == Types.Ice) || (CheckType == Types.Fly) || (CheckType == Types.Bug))
                    {
                        EffectivCounter *= 2;
                    }
                }
                else if (selectedSkill.SkillType == Types.Gohst)
                {
                    if (CheckType == Types.Dark)
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Psy) || (CheckType == Types.Gohst))
                    {
                        EffectivCounter *= 2;
                    }
                    else if (CheckType == Types.Nomal)
                    {
                        EffectivCounter = 0;
                    }
                }
                else if (selectedSkill.SkillType == Types.Dragon)
                {
                    if (CheckType == Types.Metal)
                    {
                        EffectivCounter /= 2;
                    }
                    else if (CheckType == Types.Dragon)
                    {
                        EffectivCounter *= 2;
                    }
                    else if (CheckType == Types.Fairy)
                    {
                        EffectivCounter = 0;
                    }
                }
                else if (selectedSkill.SkillType == Types.Dark)
                {
                    if ((CheckType == Types.Fight) || (CheckType == Types.Dark) || (CheckType == Types.Fairy))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Psy) || (CheckType == Types.Gohst))
                    {
                        EffectivCounter *= 2;
                    }
                }
                else if (selectedSkill.SkillType == Types.Metal)
                {
                    if ((CheckType == Types.Fire) || (CheckType == Types.Water) || (CheckType == Types.Elec) || (CheckType == Types.Metal))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Ice) || (CheckType == Types.Rock) || (CheckType == Types.Fairy))
                    {
                        EffectivCounter *= 2;
                    }
                }
                else if (selectedSkill.SkillType == Types.Fairy)
                {
                    if ((CheckType == Types.Fire) || (CheckType == Types.Poison) || (CheckType == Types.Metal))
                    {
                        EffectivCounter /= 2;
                    }
                    else if ((CheckType == Types.Fight) || (CheckType == Types.Dragon) || (CheckType == Types.Dark))
                    {
                        EffectivCounter *= 2;
                    }
                }

                if((target.HaveItem.Name == "ふうせん") && (selectedSkill.SkillType == Types.Grand)) 
                {
                    EffectivCounter = 0;
                }

                if((target.Abilities.Name == "ふゆう") && (selectedSkill.SkillType == Types.Grand)) 
                {
                    EffectivCounter = 0;
                }

            }
        }

        public static void TypeEnhanceDamage(Pokemon pokemon) 
        {
            if(pokemon.SelectedSkill.SkillType == pokemon.Abilities.TypeEnhance) 
            {
                Ability.TypeEnhanceCounter = 1.5; 
            }
            else
            {
                Ability.TypeEnhanceCounter = 1;
            }
            if(pokemon.SelectedSkill.SkillType == pokemon.HaveItem.TypeEnhance) 
            {
                if (pokemon.HaveItem.Name.Contains("プレート")) 
                {
                    Item.TypeEnhanceCounter = 1.2;
                }
                else if(pokemon.HaveItem.Name.Contains("ジュエル") && ((pokemon.SelectedSkill.Kinds == Skill.Kind.attack) || (pokemon.SelectedSkill.Kinds == Skill.Kind.cattack)))
                {
                    NoneItem noneItem = new NoneItem();
                    Console.WriteLine($"{pokemon.Name}は{pokemon.HaveItem.Name}をつかった!");
                    Item.TypeEnhanceCounter = 1.3;
                    pokemon.HaveItem = noneItem;
                    
                }
            }
            else 
            {
                Item.TypeEnhanceCounter = 1;
            }
        }

        public static void CollectSkillType(Pokemon pokemon, Skill selectedSkill)
        {
            SkillTypeCollect = 1;
            if ((selectedSkill.SkillType == pokemon.Type1) || (selectedSkill.SkillType == pokemon.Type2))
            {
                SkillTypeCollect = 1.5;
            }
            else
            {
                SkillTypeCollect = 1;

            }
        }

    }
}
