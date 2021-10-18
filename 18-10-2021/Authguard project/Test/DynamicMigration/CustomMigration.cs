using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Test.Context;

namespace Test.DynamicMigration
{
    public static class CustomMigration
    {
       public static void  MigrationIntialization(this IApplicationBuilder iapp)
        {
            using (var scope = iapp.ApplicationServices.CreateScope())
            {
                scope.ServiceProvider.GetService<AccountDbContext>().Database.Migrate();
            }
        }
        
    }
}