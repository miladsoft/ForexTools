using System.Linq;
using DNTFrameworkCore.EFCore.Caching;
using DNTFrameworkCore.EFCore.Context;
using DNTFrameworkCore.EFCore.Context.Hooks;
using DNTFrameworkCore.EFCore.Logging;
using DNTFrameworkCore.EFCore.Protection;
using DNTFrameworkCore.EFCore.SqlServer.Numbering;
using DNTFrameworkCore.Runtime;
using DNTFrameworkCore.ForexToolsWebApp.Infrastructure.Mappings.Blogging;
using DNTFrameworkCore.ForexToolsWebApp.Infrastructure.Mappings.Catalog;
using DNTFrameworkCore.ForexToolsWebApp.Infrastructure.Mappings.Identity;
using DNTFrameworkCore.ForexToolsWebApp.Infrastructure.Mappings.Invoices;
using EFSecondLevelCache.Core.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RFrameworkCore.ForexToolsWebApp.Data.Mappings.Tasks;
using DNTFrameworkCore.ForexToolsWebApp.Infrastructure.Mappings.PersonC;

namespace DNTFrameworkCore.ForexToolsWebApp.Infrastructure.Context
{
    public class ProjectDbContext : DbContextCore
    {
        public ProjectDbContext(
            IHookEngine hookEngine,
            IUserSession session,
            DbContextOptions<ProjectDbContext> options) : base(hookEngine, session, options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyLogConfiguration();
            modelBuilder.ApplyNumberedEntityConfiguration();
            modelBuilder.ApplyProtectionKeyConfiguration();
            modelBuilder.ApplySqlCacheConfiguration();
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserPermissionConfiguration());
            modelBuilder.ApplyConfiguration(new UserClaimConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RoleClaimConfiguration());
            modelBuilder.ApplyConfiguration(new RolePermissionConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new TaskConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());

            
            base.OnModelCreating(modelBuilder);
        }

        protected override void AfterSaveChanges(EntityChangeContext context)
        {
            this.GetService<IEFCacheServiceProvider>()
                .InvalidateCacheDependencies(context.EntityNames.ToArray());
        }
    }
}