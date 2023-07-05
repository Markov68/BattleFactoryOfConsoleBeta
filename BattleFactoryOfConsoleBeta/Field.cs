//using BattleOfConsole.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole
{
    internal class Field
    {

        public string Name { get; set; }

        public enum Fields
        {
            None,
            ElecField,
            PsycoField,
            GrassField,
            MistField
        }

        public static Fields CurrentField { get; set; }

        public static double FieldDamageEffect { get; set; } = 1;

        public static int FieldCount { get; set; } = 0;

        public static double GainShield { get; set; } = 1;

        public Field()
        {
            CurrentField = Fields.None;
        }

        public static void SetField(Fields field) 
        {
            CurrentField = field;
        }

        public static void FieldEffect(Skill selectedSkill,Field.Fields field) 
        {
            FieldDamageEffect = 1;
            if((selectedSkill.SkillType == Type.Types.Elec) && (Field.CurrentField == Fields.ElecField)) 
            {
                FieldDamageEffect = 1.3;
            }
            else if ((selectedSkill.SkillType == Type.Types.Psy) && (Field.CurrentField == Fields.PsycoField))
            {
                FieldDamageEffect = 1.3;
            }
            else if ((selectedSkill.SkillType == Type.Types.Leaf) && (Field.CurrentField == Fields.GrassField))
            {
                FieldDamageEffect = 1.3;
            }
            else if ((selectedSkill.SkillType == Type.Types.Dragon) && (Field.CurrentField == Fields.MistField))
            {
                FieldDamageEffect = 0.5;
            }
        }


    }
}
