using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Feeblemind : Template
    {
        public static readonly Guid ID = Guid.Parse("20718a32-54fb-47d6-a948-6d4c006633ec");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Feeblemind",
                Level = 6,
                Range = "30 feet.",
                Duration = "Varies",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b9f96c1-8c20-403c-9d9d-4244ebc4c92a"), Type = TextBlockType.Text, Text = "You drastically reduce the target’s mental faculties. The target must attempt a Will save. The effects of this curse can be removed only through remove curse or another effect that targets curses." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c7e8c8ee-cc60-4a75-ba5e-f5d4f4a4dee1"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is stupefied 2 for 1 round.",
                Failure = "The target is stupefied 4 with an unlimited duration.",
                CriticalFailure = "The target’s intellect is permanently reduced below that of an animal, and it treats its Charisma, Intelligence, and Wisdom modifiers as –5. It loses all class abilities that require mental faculties, including all spellcasting. If the target is a PC, they become an NPC under the GM’s control."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ca649cc-47bd-4bbd-a43b-233a7b200af4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 337
            };
        }
    }
}
