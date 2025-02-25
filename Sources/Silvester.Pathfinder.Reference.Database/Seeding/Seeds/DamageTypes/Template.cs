using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes
{
    public abstract class Template : EntityTemplate<DamageType>
    {
        protected override DamageType GetEntity(ModelBuilder builder)
        {
            DamageType damageType = GetAction();
            return damageType;
        }

        protected abstract DamageType GetAction();
    }
}
