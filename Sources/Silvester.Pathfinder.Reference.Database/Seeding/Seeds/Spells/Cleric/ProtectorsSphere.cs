using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ProtectorsSphere : Template
    {
        public static readonly Guid ID = Guid.Parse("bd0e4e43-3d47-4e47-8d4a-d60607fef58e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Protector's Sphere",
                Level = 4,
                Area = "15-foot emanation.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                DomainId = Domains.Instances.Protection.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("68dd6f78-7681-41af-905f-a2388286f3f1"), Type = TextBlockType.Text, Text = "A protective aura emanates out from you, safeguarding you and your allies. You gain resistance 3 to all damage. Your allies also gain this resistance while they are within the area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("06953c68-6081-4ade-9b42-7082c5899e8f"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("98489dc7-815e-4014-afcf-62062c4f0c93"), Type = TextBlockType.Text, Text = "The resistance increases by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
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
                Id = Guid.Parse("cdfa3f66-1f6e-42e1-887e-750ed6121745"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 395
            };
        }
    }
}
