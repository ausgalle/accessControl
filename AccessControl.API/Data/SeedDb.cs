using AccessControl.API.Data;
using Azure;
using Microsoft.EntityFrameworkCore;

namespace Sales.Api.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;    
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckAccessControlerAsync();
        }
        

        private async Task CheckAccessControlerAsync()
        {
            //if (!_context.Categories.Any())
            //{
            //    _context.Categories.Add(new Category { Name = "Apple" });
            //    _context.Categories.Add(new Category { Name = "Autos" });
            //    _context.Categories.Add(new Category { Name = "Belleza" });
            //    _context.Categories.Add(new Category { Name = "Calzado" });
            //    _context.Categories.Add(new Category { Name = "Comida" });
            //    _context.Categories.Add(new Category { Name = "Cosmeticos" });
            //    _context.Categories.Add(new Category { Name = "Deportes" });
            //    _context.Categories.Add(new Category { Name = "Erótica" });
            //    _context.Categories.Add(new Category { Name = "Ferreteria" });
            //    _context.Categories.Add(new Category { Name = "Gamer" });
            //    _context.Categories.Add(new Category { Name = "Hogar" });
            //    _context.Categories.Add(new Category { Name = "Jardín" });
            //    _context.Categories.Add(new Category { Name = "Jugetes" });
            //    _context.Categories.Add(new Category { Name = "Lenceria" });
            //    _context.Categories.Add(new Category { Name = "Mascotas" });
            //    _context.Categories.Add(new Category { Name = "Nutrición" });
            //    _context.Categories.Add(new Category { Name = "Ropa" });
            //    _context.Categories.Add(new Category { Name = "Tecnología" });
            //    await _context.SaveChangesAsync();
            //}
        }
    }
}
