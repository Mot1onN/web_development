namespace FunFinder.Web.Features.Selection;

internal sealed record ActivityDirection(string Slug, string Title, string Description, string Symbol)
{
    public static IReadOnlyList<ActivityDirection> All { get; } = Array.AsReadOnly<ActivityDirection>(
    [
        new("food", "Покушать", "Кафе, рестораны и кофейни", "♨"),
        new("fun", "Поразвлечься", "Картинг, боулинг и бильярд", "✦"),
        new("walk", "Погулять", "Парки, скверы и набережные", "⌁")
    ]);
}
