namespace Infamy.ApiService.Types.Inputs
{
    public sealed record AddDeveloperInput(
        string Name,
        int? HP,
        int? XP,
        int? Level
    );
}
