using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Pluto.Models;

namespace Pluto.Data
{
   public class PlutoContextSeedData
    {
        private PlutoContext _context;
        private UserManager<PlutoUser> _userManager;
        private RoleManager<PlutoRole> _roleManager;

        public PlutoContextSeedData(PlutoContext context,
            UserManager<PlutoUser> userManager,RoleManager<PlutoRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SeedAsync()
        {
            // Seed User
            if (await _userManager.FindByNameAsync("ronithomas@gmail.com") == null)
            {
                var user = new PlutoUser()
                {
                    Email = "ronithomas@gmail.com",
                    UserName = "ronithomas@gmail.com",
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(user, "DDdd@1234"); // Temp Password
                if (!result.Succeeded) throw new InvalidProgramException("Failed to create seed user");
            }

            // Seed User
            if (await _userManager.FindByNameAsync("hakim@gmail.com") == null)
            {
                var user = new PlutoUser()
                {
                    Email = "hakim@gmail.com",
                    UserName = "hakim@gmail.com",
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(user, "DDdd@1234"); // Temp Password
                if (!result.Succeeded) throw new InvalidProgramException("Failed to create seed user");
            }

             if (await _roleManager.FindByNameAsync("Manager") ==null)
            {
                var role = new PlutoRole()
                {
                    Name="Manager"
                };

                var result1 = await _roleManager.CreateAsync(role);

                if (!result1.Succeeded) throw new InvalidProgramException("Failed to create seed role");
            }


        }

    }
}
