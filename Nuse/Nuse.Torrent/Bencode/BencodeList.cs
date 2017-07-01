using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Nuse.Torrent.Bencode
{
    public sealed class BencodeList : IBencodeObject
    {
        private readonly List<object> _obj;

        public int Count => _obj.Count;

        public BencodeList()
        {
            _obj = new List<object>();
        }

        public BencodeList(List<object> obj)
        {
            _obj = obj;
        }

        public override string ToString()
        {
            var objFact = new BencodeObjectFactory();
            var encodedList = "";

            foreach (var lobj in _obj)
            {
                encodedList += objFact.Create(lobj).ToString();
            }

            return $"l{encodedList}e";
        }

        public void Add(object obj)
        {
            _obj.Add(obj);
        }
    }
}