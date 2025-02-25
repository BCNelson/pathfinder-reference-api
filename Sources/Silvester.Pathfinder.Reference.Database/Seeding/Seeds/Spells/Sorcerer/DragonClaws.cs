using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Sorcerer.Instances
{
    public class DragonClaws : Template
    {
        public static readonly Guid ID = Guid.Parse("979b1764-d560-4ff0-945a-2f2f26e9acbc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dragon Claws",
                Level = 1,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("56d382eb-341d-44e6-aaf1-0a5665eb538c"), Type = TextBlockType.Text, Text = "Vicious claws grow from your fingers. They are finesse unarmed attacks that deal 1d4 slashing damage and 1d6 extra damage of a type determined by the dragon in your bloodline (see the table in dragon breath). Your scales from blood magic glow with faint energy, giving you resistance 5 to the same damage type." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d323d3f6-b8c9-4657-a9d0-3d803bb04b19"),
                Level = "+5th",
                Details =
                {
                   new TextBlock { Id = Guid.Parse("c2714387-db34-4de4-b101-d26a083e7447"), Type = TextBlockType.Text, Text = "The extra damage increases to 2d6, and the resistance increases to 10." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("565977e9-f022-4134-bf53-960a17221252"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("26fb7e49-93e5-410d-a3da-d0de5656c4ab"), Type = TextBlockType.Text, Text = "The extra damage increases to 3d6, and the resistance increases to 15." }
                }
            };
        }
        
        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Sorcerer.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7dad1414-47f3-41f1-ac2f-12eead578725"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 403
            };
        }
    }
}
