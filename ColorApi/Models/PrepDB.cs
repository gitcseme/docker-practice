using System;
using ColorApi.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace ColorApi.Models
{
    public static class PrepDB
    {
        public static void Prepare(IApplicationBuilder app) 
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ColorContext>());
            }
        }

        public static void SeedData(ColorContext colorContext)
        {
            System.Console.WriteLine("Applying migrations...");
            colorContext.Database.Migrate();

            if (!colorContext.Colors.Any())
            {
                System.Console.WriteLine("Adding data - seeding...");
                colorContext.Colors.AddRange(
                    new Color() {ColorName = "Red"},
                    new Color() {ColorName = "Orange"},
                    new Color() {ColorName = "Yellow"},
                    new Color() {ColorName = "Green"},
                    new Color() {ColorName = "Blue"}
                );

                colorContext.SaveChanges();
            }
            else {
                System.Console.WriteLine("Already have data - no seeding");
            }
        }
    }
}