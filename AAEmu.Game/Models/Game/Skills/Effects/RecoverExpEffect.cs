using System;
using AAEmu.Game.Models.Game.Skills.Templates;
using AAEmu.Game.Models.Game.Units;

namespace AAEmu.Game.Models.Game.Skills.Effects
{
    public class RecoverExpEffect : EffectTemplate
    {
        public bool NeedMoney { get; set; }
        public bool NeedLaborPower { get; set; }

        public bool NeedPriest { get; set; }
        // TODO 1.2 // public bool Penaltied { get; set; }

        public override bool OnActionTime => false;

        public override void Apply(Unit caster, SkillAction casterObj, BaseUnit target, SkillAction targetObj, CastAction castObj,
            Skill skill, DateTime time)
        {
            _log.Debug("RecoverExpEffect");
        }
    }
}