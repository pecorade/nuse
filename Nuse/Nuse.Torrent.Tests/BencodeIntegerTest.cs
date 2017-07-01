using Nuse.Torrent.Bencode;
using NUnit.Framework;

namespace Nuse.Torrent.Tests
{
    [TestFixture]
    public class BencodeIntegerTest
    {
        [Test]
        public void TestNewBencodeInteger()
        {
            var bint = new BencodeInteger();
            
            Assert.IsNotNull(bint);
            Assert.AreEqual(0, bint.Value);
        }

        [Test]
        public void TestBencodeIntegerToString()
        {
            var bint = new BencodeInteger(4);
            
            Assert.IsNotNull(bint);
            Assert.AreEqual(4, bint.Value);
            Assert.AreEqual("i4e", bint.ToString());
        }
    }
}