﻿using CoreAPISeedData_1.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreAPISeedData_1.Extensions
{
    public static class DataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Primary Key identity'si burada tetiklenmez...DOlayısıyla ID'yi burada elle vermeliyiz...

            Category c = new()
            {
                ID = 1,
                CategoryName = "Tatlılar",
                Description = "Denem verisidir"
            };

            modelBuilder.Entity<Category>().HasData(c);
        }
    }
}
