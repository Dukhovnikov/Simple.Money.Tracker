using SImpleMoneyTracker.WinForms.Implementation.Models;

namespace SimpleMoneyTracker.WinForms
{
    public interface IRepository : 
        ICollectionsModification<Category>
    {
        Project Projects { get; set; }

        void Add(Category category, Transaction transaction);
        void Remove(Transaction transaction);
        void SaveChanges();
    }
}