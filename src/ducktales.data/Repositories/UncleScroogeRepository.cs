using System.Collections.Generic;
using System.Threading.Tasks;
using ducktales.data.Interfaces;
using ducktales.models;

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedMember.Global

namespace ducktales.data.Repositories {
    
    public class UncleScroogeRepository : IUncleScroogeRepository {
        
        public async Task<SafeBox> GetSafeBox() {
            return await Task.Run(() => new SafeBox(new List<Coin>
            {
                new Coin(0.01m, 0.25m),
                new Coin(0.01m, 0.25m)
            }));
        }
    }
}