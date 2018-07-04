using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using ducktales.data.Repositories;
using ducktales.models;
using Newtonsoft.Json;
using NUnit.Framework;

namespace ducktales.tests.Repositories {
    
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class UngleScroogeRepositoryTests {

        private UncleScroogeRepository _ungleScroogeRepository;

        private const string ExpectedResponse = "{'coins':[{'weight':0.01,'value':0.25},{'weight':0.01,'value':0.25}]}";
        private const string IncorrectResponse = "{'coins':[{'weight':0.01,'value':0.25}]}";
        private const string IncorrectCoinResponse = "{'coins':[{'weight':0.01,'value':0.25},{'weight':0.01,'value':0.26}]}";

        [SetUp]
        public void Setup() {
            _ungleScroogeRepository = new UncleScroogeRepository();
        }
        
        [Test]
        public async Task Should_GetSafeBox_CorrectResponse() {
            var expected = JsonConvert.DeserializeObject<SafeBox>(ExpectedResponse);
            var result = await _ungleScroogeRepository.GetSafeBox();
            
            Assert.IsTrue(result.Equals(expected));
        }
        
        [Test]
        public async Task Should_GetSafeBox_IncorrectResponse() {
            var expected = JsonConvert.DeserializeObject<SafeBox>(IncorrectResponse);
            var result = await _ungleScroogeRepository.GetSafeBox();
            
            Assert.IsFalse(result.Equals(expected));
        }
        
        [Test]
        public async Task Should_GetSafeBox_IncorrectCoinResponse() {
            var expected = JsonConvert.DeserializeObject<SafeBox>(IncorrectCoinResponse);
            var result = await _ungleScroogeRepository.GetSafeBox();
            
            Assert.IsFalse(result.Equals(expected));
        }
    }
}