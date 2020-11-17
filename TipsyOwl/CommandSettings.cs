namespace TipsyOwl
{
    public class CommandSettings
    {
        public string? CommandPrefix { get; init; }
        public bool AllowInlineCommands { get; init; }
        public string? InlineCommandAlias { get; init; }
        public string? InlineCommandOpener { get; init; }
        public string? InlineCommandCloser { get; init; }
    }
}