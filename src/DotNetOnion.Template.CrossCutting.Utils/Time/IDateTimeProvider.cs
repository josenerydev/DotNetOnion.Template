namespace DotNetOnion.Template.CrossCutting.Utils.Time
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
        DateTime Today { get; }
    }
}
