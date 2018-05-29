namespace SimpleMoneyTracker.WinForms
{
    public interface ICollectionsModification<in T>
    {
        void Add(T entity);
        void Remove(T entity);
    }
}