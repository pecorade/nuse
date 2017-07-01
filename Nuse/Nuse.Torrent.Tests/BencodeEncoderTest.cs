using System.Collections.Generic;
using Nuse.Torrent.Bencode;
using NUnit.Framework;

namespace Nuse.Torrent.Tests
{
    [TestFixture]
    public class BencodeEncoderTest
    {
        [Test]
        public void TestNewEncoder()
        {
            var encoder = new BencodeEncoder();
            Assert.IsNotNull(encoder);
        }

        [Test]
        public void TestEncodeString()
        {
            var test1 = "foo";
            var test2 = "spam";
            var test3 = "Hello world";
            
            var encoder = new BencodeEncoder();

            var encoded1 = encoder.Encode(test1);
            var encoded2 = encoder.Encode(test2);
            var encoded3 = encoder.Encode(test3);
            
            Assert.IsNotNull(encoder);
            Assert.AreEqual("3:foo", encoded1);
            Assert.AreEqual("4:spam", encoded2);
            Assert.AreEqual("11:Hello world", encoded3);
        }
        
        [Test]
        public void TestEncodeInteger()
        {
            const int test1 = 8;
            const int test2 = 765;
            
            var encoder = new BencodeEncoder();

            var encoded1 = encoder.Encode(test1);
            var encoded2 = encoder.Encode(test2);
            
            Assert.IsNotNull(encoder);
            Assert.AreEqual("i8e", encoded1);
            Assert.AreEqual("i765e", encoded2);
        }

        [Test]
        public void TestEncodeList()
        {
            var objList = new List<object> {"foo", "bar", "spam", 5};    
            var encoder = new BencodeEncoder();
            var encoded = encoder.Encode(objList);
            
            Assert.IsNotNull(encoder);
            Assert.AreEqual("l3:foo3:bar4:spami5ee", encoded);
        }
        
        [Test]
        public void TestEncodeListWithSublist()
        {
            var objList = new List<object> {"foo", "bar", "spam", 5};
            var subList = new List<object> {"hello", "world", 9};
            
            objList.Add(subList);
            
            var encoder = new BencodeEncoder();
            var encoded = encoder.Encode(objList);
            
            Assert.IsNotNull(encoder);
            Assert.AreEqual("l3:foo3:bar4:spami5el5:hello5:worldi9eee", encoded);
        }
        
        [Test]
        public void TestEncodeDictionary()
        {
            var objDictionary = new Dictionary<object, object>();
            
            objDictionary.Add("filename", "miofile.txt");
            objDictionary.Add("size", 76500);
            
            var encoder = new BencodeEncoder();
            var encoded = encoder.Encode(objDictionary);
            
            Assert.IsNotNull(encoder);
            Assert.AreEqual("d8:filename11:miofile.txt4:sizei76500ee", encoded);
        }
    }
}