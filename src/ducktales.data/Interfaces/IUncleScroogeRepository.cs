using System.Threading.Tasks;
using ducktales.models;

namespace ducktales.data.Interfaces {
    
    public interface IUncleScroogeRepository {
        Task<SafeBox> GetSafeBox();
    }
}