using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using ducktales.api.Controllers;
using ducktales.data.Interfaces;
using ducktales.models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NSubstitute;
using NUnit.Framework;

namespace ducktales.tests.Controller {
    
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class DucktalesControllerTests {
        
        private const string SuccessResponse = "{'coins':[{'weight':0.01,'value':0.25},{'weight':0.01,'value':0.25}]}";

        private IUncleScroogeRepository _uncleScroogeRepository;
        private DucktalesController _ducktalesController;

        [SetUp]
        public void Setup() {
            _uncleScroogeRepository = Substitute.For<IUncleScroogeRepository>();
            _ducktalesController = new DucktalesController(_uncleScroogeRepository);
        }

        [Test]
        public async Task Should_GetSafeBox_CorrectResponse() {
            const string passphrase = "MySafeBox";
            
            _uncleScroogeRepository.GetSafeBox()
                .Returns(Task.FromResult(JsonConvert.DeserializeObject<SafeBox>(SuccessResponse)));

            var result = await _ducktalesController.Get(passphrase);
            Assert.IsInstanceOf<OkObjectResult>(result);
        }
        
        [Test]
        public async Task Should_GetSafeBox_IncorrectResponse() {
            var result = await _ducktalesController.Get(string.Empty);
            Assert.IsInstanceOf<BadRequestResult>(result);
        }
    }
}