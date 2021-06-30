using NUnit.Framework;

namespace SourceGenApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var result = HelloWorldGenerated.HelloWorld.SayHello();
            Assert.That(result, Is.EqualTo(42));
        }
    }
}