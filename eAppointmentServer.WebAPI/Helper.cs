﻿using eAppointmentServer.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace eAppointmentServer.WebAPI
{
	public static class Helper
	{
		public static async Task CreateUserAsync(WebApplication app)
		{
			using (var scoped = app.Services.CreateScope())
			{
				var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
				if (!userManager.Users.Any())
				{
					await userManager.CreateAsync(new()
					{
						FirstName = "Mustafa",
						LastName = "Erkekli",
						Email = "emustafaerkekli.ee@gmail.com",
						UserName = "admin",
					}, "1");
				}
			}
		}
	}
}
