using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beryllium_Back_End.DAL;
using Beryllium_Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Beryllium_Back_End.Service
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<AnotherSetting>> GetDatas()
        {
            List<AnotherSetting> anotherSettings = await _context.AnotherSettings.ToListAsync();

            return anotherSettings;
        }
    }
}
