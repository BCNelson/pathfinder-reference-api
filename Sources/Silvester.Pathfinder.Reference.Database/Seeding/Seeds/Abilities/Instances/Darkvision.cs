using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Darkvision : Template
    {
        public static readonly Guid ID = Guid.Parse("38f65090-50a0-4ccc-ac6c-cd0f0005ec11");

        public override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Darkvision"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("383d2264-2528-46d3-88b1-265b29bbc47a"), Type = TextBlockType.Text, Text = "A monster with darkvision can see perfectly well in areas of darkness and dim light, though such vision is in black and white only. Some forms of magical darkness, such as a 4th-level darkness spell, block normal darkvision. A monster with greater darkvision, however, can see through even these forms of magical darkness." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0311baf1-0460-467e-8420-8d70a7416fe8"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
