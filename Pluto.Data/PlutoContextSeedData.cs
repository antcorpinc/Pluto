using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Pluto.Entities;

namespace Pluto.Data
{
   public class PlutoContextSeedData
    {
        private PlutoContext _context;
        private UserManager<PlutoUser> _userManager;

        public PlutoContextSeedData(PlutoContext context,
            UserManager<PlutoUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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
        }

    }
}
