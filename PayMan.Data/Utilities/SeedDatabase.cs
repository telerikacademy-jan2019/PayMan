﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PayMan.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMan.Data.Utilities
{
    public static class SeedDatabase
    {
        public static async Task SeedAdminAsync(IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<PayContext>();
                if (!dbContext.Roles.Any(x => x.Name == DataConstants.RoleAdmin))
                {
                    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                    await roleManager.CreateAsync(new IdentityRole { Name = DataConstants.RoleAdmin });
                    await roleManager.CreateAsync(new IdentityRole { Name = DataConstants.RoleUser });
                }

                if (!dbContext.Users.Any(x => x.UserName == DataConstants.UsernameAdmin))
                {
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

                    var adminUser = new User { UserName = DataConstants.UsernameAdmin, Email = DataConstants.EmailAdmin };
                    await userManager.CreateAsync(adminUser, DataConstants.PasswordAdmin);
                    await userManager.AddToRoleAsync(adminUser, DataConstants.RoleAdmin);
                }
            }
        }
    }
}
