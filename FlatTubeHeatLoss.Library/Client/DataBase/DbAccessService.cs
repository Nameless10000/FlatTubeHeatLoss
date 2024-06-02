using Client.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataBase
{
    public static class DbAccessService
    {
        private static DBContext _dbContext = new();

        public static async Task<Material?> GetMaterial(int id)
        {
            return await _dbContext.Materials
                .Include(x => x.Group)
                .FirstOrDefaultAsync(x => x.ID == id);
        }

        public static async Task<List<Material>> GetMaterials()
        {
            return await _dbContext.Materials
                .Include(x => x.Group)
                .ToListAsync();
        }

        public static async Task<List<Group>> GetGroups()
        {
            return await _dbContext.Groups.ToListAsync();
        }

        public static async Task<IEnumerable<IGrouping<int, Material>>> GetMaterialsByGroup()
        {
            return (await _dbContext.Materials
                .Include(x => x.Group)
                .ToListAsync())
                .GroupBy(x => x.GroupID);
        }
    }
}
