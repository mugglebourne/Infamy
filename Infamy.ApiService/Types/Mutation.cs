using Infamy.ApiService.DataModels;
using Infamy.ApiService.Types.Inputs;
using Infamy.ApiService.Types.MutationPayloads;
using Infamy.ServiceDefaults.Models;
using System.Threading;

namespace Infamy.ApiService.Types
{
    public class Mutation
    {
        //[Mutation]
        public async Task<AddDeveloperPayload> AddDeveloperAsync(AddDeveloperInput input, ApplicationDbContext dbContext, CancellationToken token)
        {
            Developer developer = new Developer
            {
                Name = input.Name,
                HP = 100,
                XP = 0,
                Level = 0
            };

            dbContext.Developers.Add(developer);
            await dbContext.SaveChangesAsync(token);
            return new AddDeveloperPayload(developer);
        }
    }
}
