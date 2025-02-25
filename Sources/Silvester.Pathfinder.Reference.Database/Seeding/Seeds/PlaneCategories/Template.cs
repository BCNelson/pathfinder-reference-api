using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlaneCategories
{
    public abstract class Template : EntityTemplate<PlaneCategory>
    {
        protected override PlaneCategory GetEntity(ModelBuilder builder)
        {
            PlaneCategory category = GetPlaneCategory();
            return category;
        }

        protected abstract PlaneCategory GetPlaneCategory();
    }
}
