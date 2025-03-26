using Infamy.ApiService.DataModels;
using Infamy.ServiceDefaults.Models;
using Microsoft.EntityFrameworkCore;

namespace Infamy.ApiService.Types
{

    public class Query
    {
        //[Query]
        public async Task<IEnumerable<Developer>> GetDevelopersAsync(ApplicationDbContext dbContext, CancellationToken token)
        {
            List<Developer> developers = await dbContext.Developers.AsNoTracking().ToListAsync(token);
            return developers;
        }

        //[Query]
        public async Task<IEnumerable<Tool>> GetToolsAsync(ApplicationDbContext dbContext, CancellationToken token)
        { 
            List<Tool> tools = await dbContext.Tools.AsNoTracking().ToListAsync(token);
            return tools;
        }
    }
}
