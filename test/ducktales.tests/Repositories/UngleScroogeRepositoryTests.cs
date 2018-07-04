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

        [SetUp]
        public void Setup() {
            _ungleScroogeRepository = new UncleScroogeRepository();
        }

        [Test]
        public async Task Should_GetSafeBox_CorrectResponse() {
            var expected = JsonConvert.DeserializeObject<SafeBox>(ExpectedResponse);
            var result = await _ungleScroogeRepository.GetSafeBox();
            
            Assert.IsTrue(expected.Equals(result));
        } 
    }
}