﻿using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Api.Graphql.Searching;
using Silvester.Pathfinder.Reference.Api.Graphql.Searching.Models;
using Silvester.Pathfinder.Reference.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Api.Graphql
{
    public partial class Query
    {
        [UseDbContext(typeof(ReferenceDatabase))]
        public IEnumerable<SearchResult> Search([ScopedService] ReferenceDatabase database, string searchTerm)
        {
            return new SearchService(database).Search(searchTerm);
        }
    }

    public class QueryType : ObjectType<Query>
    { 
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            foreach (PropertyInfo property in typeof(ReferenceDatabase).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (property.PropertyType.IsAssignableTo(typeof(DbSet<>)) || property.PropertyType.IsGenericType == false)
                {
                    continue;
                }

                Type genericType = property.PropertyType.GetGenericArguments().First();
                if (genericType.IsAssignableTo(typeof(BaseEntity)) == false)
                {
                    continue;
                }

                //TODO: Try and get a hold of the injected naming convention here.
                string fieldName = char.ToLowerInvariant(property.Name[0]) + property.Name.Substring(1);
                IObjectFieldDescriptor field = descriptor
                    .Field(fieldName)
                    .Type(genericType)
                    .UseDbContext<ReferenceDatabase>()
                    .UseOffsetPaging(typeof(ObjectType<>).MakeGenericType(genericType));
                
                InvokeUseProjectionMethod(genericType, field);
                
                field
                    .UseFiltering(genericType)
                    .UseSorting(genericType)
                    .Resolve((context) =>
                    {
                        ReferenceDatabase database = context.Resolver<ReferenceDatabase>();
                        return property.GetValue(database);
                    });
            }
        }

        private static void InvokeUseProjectionMethod(Type genericType, IObjectFieldDescriptor field)
        {
            MethodInfo? method = typeof(ProjectionObjectFieldDescriptorExtensions).GetMethod("UseProjection", 1, new[] { typeof(IObjectFieldDescriptor), typeof(string) });

            method!
                .MakeGenericMethod(genericType)
                .Invoke(null, new object?[] { field, null });
        }
    }
}
