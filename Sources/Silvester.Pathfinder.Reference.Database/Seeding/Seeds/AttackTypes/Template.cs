using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AttackTypes
{
    public abstract class Template : EntityTemplate<AttackType>
    {
        protected override AttackType GetEntity(ModelBuilder builder)
        {
            AttackType type = GetAttackType();
            return type;
        }

        protected abstract AttackType GetAttackType();
    }
}
