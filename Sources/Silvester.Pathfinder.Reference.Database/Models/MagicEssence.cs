using NpgsqlTypes;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class MagicEssence : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
