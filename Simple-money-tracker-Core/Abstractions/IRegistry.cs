namespace Simple_money_tracker_Core.Abstractions
{
    public interface IRegistry
    {
        IProjectBuilder ProjectBuilder { get; set; }
        IShowDataToUser ShowDataToUser { get; set; }
    }
}