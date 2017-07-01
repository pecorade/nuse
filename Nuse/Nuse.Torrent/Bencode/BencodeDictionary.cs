using System.Collections.Generic;

namespace Nuse.Torrent.Bencode
{
    public sealed class BencodeDictionary : IBencodeObject
    {
        private readonly Dictionary<object, object> _obj;
        
        public BencodeDictionary(Dictionary<object, object> obj)
        {
            _obj = obj;
        }
        
        public override string ToString()
        {
            var objFact = new BencodeObjectFactory();
            var encodedList = "";

            foreach (var dkey in _obj.Keys)
            {
                encodedList += $"{objFact.Create(dkey)}{objFact.Create(_obj[dkey])}";
            }
            
            return $"d{encodedList}e";
        }
    }
}