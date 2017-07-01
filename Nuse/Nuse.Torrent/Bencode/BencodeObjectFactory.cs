using System;
using System.Collections.Generic;

namespace Nuse.Torrent.Bencode
{
    public sealed class BencodeObjectFactory
    {
        public IBencodeObject Create(object obj)
        {
            IBencodeObject factoryObj = null;
            var objType = obj.GetType();
            
            if (objType == typeof(string))
                factoryObj = new BencodeString((string) obj);
            else if (objType == typeof(int))
                factoryObj = new BencodeInteger((int) obj);
            else if (objType == typeof(List<object>))
                factoryObj = new BencodeList((List<object>) obj);
            else if (objType == typeof(Dictionary<object, object>))
                factoryObj = new BencodeDictionary((Dictionary<object, object>) obj);
            
            return factoryObj;
        }
    }
}