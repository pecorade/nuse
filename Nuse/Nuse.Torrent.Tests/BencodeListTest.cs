using Nuse.Torrent.Bencode;
using NUnit.Framework;

namespace Nuse.Torrent.Tests
{
    [TestFixture]
    public class BencodeListTest
    {
        [Test]
        public void TestNewBencodeList()
        {
            var blist = new BencodeList();

            Assert.IsNotNull(blist);
            Assert.AreEqual(0, blist.Count);
        }

        [Test]
        public void TestBencodeListToString()
        {
            var blist = new BencodeList();
            var bobj = "hello";
            blist.Add(bobj);

            Assert.IsNotNull(blist);
            Assert.AreEqual("l5:helloe", blist.ToString());
        }
    }
}