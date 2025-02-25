using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TempestTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("63252b43-57d0-40fc-a734-b871d24d7fef");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tempest Touch",
                Level = 1,
                Range = "Touch.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc397103-1210-4b49-99b6-6189bc825d58"), Type = TextBlockType.Text, Text = "Your touch calls forth a churning mass of icy water that clings to your target, dealing 1d4 bludgeoning damage and 1d4 cold damage. The target must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9951e216-3946-4bf4-be9d-0e5942e942f4"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("1f2a3a7f-4c15-4df2-870d-ea8d1c7be518"), Type = TextBlockType.Text, Text = "The bludgeoning and cold damage each increase by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("72f653df-221d-4d57-b0bc-e8a367e2344a"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage and a –5-foot circumstance penalty to its Speeds until the end of your next turn.",
                Failure = "The target takes full damage and a –10-foot circumstance penalty to its Speeds until the end of your next turn.",
                CriticalFailure = "As failure, but the target takes double damage."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Oracle.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b3ef0a7-36cf-4e7f-a338-878c732a075e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 233
            };
        }
    }
}
