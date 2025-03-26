//using Infamy.ApiService.DataModels;
using Infamy.ServiceDefaults.Models;

namespace Infamy.ApiService.Types.MutationPayloads
{
    public sealed class AddDeveloperPayload(Developer developer)
    {
        public Developer Developer { get; } = developer;
    }
}
