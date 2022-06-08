using NUnit.Framework;


namespace StringCompressionTask.Tests
{
    [TestFixture]
    public class CompressTests
    {
        [TestCase("kkkktttrrrrrrrrrr", ExpectedResult = "k4t3r10")]
        [TestCase("p555ppp7www", ExpectedResult = "p153p371w3")]
        public string ReturnRightAmountOfCharFound(string word)
        {
            var compress = new Compress();

            return compress.CompressString(word);

        }
    }
}