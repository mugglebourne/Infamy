using Infamy.ServiceDefaults.Models;
using System.ComponentModel.DataAnnotations;
//using Infamy.ApiService.DataModels;

namespace Infamy.ApiService.Types
{
    [GraphQLDescription("Languages/Frameworks used. Displays level of mastery")]
    public class ToolType : ObjectType<Tool>
    {
    }
}
