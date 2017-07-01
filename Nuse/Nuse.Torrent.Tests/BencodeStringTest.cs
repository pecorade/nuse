using Nuse.Torrent.Bencode;
using NUnit.Framework;

namespace Nuse.Torrent.Tests
{
    [TestFixture]
    public class BencodeStringTest
    {
        [Test]
        public void TestNewBencodeString()
        {
            var bstring = new BencodeString();
            
            Assert.IsNotNull(bstring);
            Assert.AreEqual(string.Empty, bstring.Value);
        }

        [Test]
        public void TestBencodeStringToString()
        {
            var bstring1 = new BencodeString("hello");
            var bstring2 = new BencodeString("hello world");
            var bstring3 = new BencodeString("hello, world");
            
            Assert.IsNotNull(bstring1);
            Assert.IsNotNull(bstring2);
            Assert.IsNotNull(bstring3);
            
            Assert.AreEqual("hello", bstring1.Value);
            Assert.AreEqual("hello world", bstring2.Value);
            Assert.AreEqual("hello, world", bstring3.Value);
            
            Assert.AreEqual("5:hello", bstring1.ToString());
            Assert.AreEqual("11:hello world", bstring2.ToString());
            Assert.AreEqual("12:hello, world", bstring3.ToString());
        }
    }
}