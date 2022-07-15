using System.Threading.Tasks;

namespace NerdStore.Core.DomainObjects.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
