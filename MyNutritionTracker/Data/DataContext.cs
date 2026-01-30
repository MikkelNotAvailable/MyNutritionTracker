using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyNutritionTracker.Data;

namespace MyNutritionTracker.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<FoodUser>(options)
    {
        public DbSet<MyNutritionTracker.Models.FoodItem> FoodItem { get; set; } = default!;
    }
}
