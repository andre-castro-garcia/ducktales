using System.Threading.Tasks;
using ducktales.data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ducktales.api.Controllers {
    
    [Route("ducktales")]
    public class DucktalesController : Controller {

        private readonly IUncleScroogeRepository _uncleScroogeRepository;

        public DucktalesController(IUncleScroogeRepository uncleScroogeRepository) {
            _uncleScroogeRepository = uncleScroogeRepository;
        }
        
        public async Task<IActionResult> Get([FromQuery] string passphrase) {
            if (string.IsNullOrEmpty(passphrase))
                return BadRequest();
            
            var result = await _uncleScroogeRepository.GetSafeBox();
            return Ok(result);
        }
    }
}