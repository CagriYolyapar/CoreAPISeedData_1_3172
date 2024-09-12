using CoreAPISeedData_1.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreAPISeedData_1.CustomTools
{
    public static class DataSeedStructure
    {
        
        public static void KategoriEkle(ModelBuilder modelBuilder)
        {
            Category c = new()
            {
                CategoryName = "Tatlılar",
                Description = "Deneme verisidir"
            };

            modelBuilder.Entity<Category>().HasData(c);
            
        }
    }
}
