using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EnduringMight : Template
    {
        public static readonly Guid ID = Guid.Parse("f1f36fab-0f37-4db1-b527-bc4d62cc0f21");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Enduring Might",
                Level = 4,
                Trigger = "An attack or effect would deal damage to you.",
                DomainId = Domains.Instances.Might.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d2bae60-3c75-4f67-a95c-8869407eec0a"), Type = TextBlockType.Text, Text = "Your own might mingles with divine power to protect you. You gain resistance equal to 8 plus your Strength modifier against all damage from the triggering attack or effect." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c5deeb75-705f-41a5-a95d-ba9dc982836f"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("579a7a41-0aab-478e-820e-47a241702cef"), Type = TextBlockType.Text, Text = "The resistance increases by 2." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Cleric.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5b61367-8f2b-46b7-86c0-58f7f121c04c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 392
            };
        }
    }
}
