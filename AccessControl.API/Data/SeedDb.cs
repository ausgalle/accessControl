using AccessControl.API.Data;
using AccessControl.Shared.Entities;
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
            if (!_context.mvTickets.Any())
            {
                int numOfRowsToInsert = 50000;

                for (int i = 1; i <= numOfRowsToInsert; i++)
                {
                    _context.mvTickets.Add(new MvTicket
                    {
                        FechaUso = null,
                        FueUsada = false,
                        Porteria = null
                    });
                }
                await _context.SaveChangesAsync();
            }
        }
    }
}
