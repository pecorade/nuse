using System.Collections.Generic;

namespace Nuse.Torrent.Bencode
{
    public sealed class BencodeEncoder
    {
        public string Encode(string obj)
        {
            var encoded = new BencodeString(obj);
            
            return encoded.ToString();
        }

        public string Encode(int obj)
        {
            var encoded = new BencodeInteger(obj);

            return encoded.ToString();
        }

        public string Encode(List<object> obj)
        {
            var encoded = new BencodeList(obj);
            
            return encoded.ToString();
        }

        public string Encode(Dictionary<object, object> obj)
        {
            var encoded = new BencodeDictionary(obj);
            
            return encoded.ToString();
        }
    }
}