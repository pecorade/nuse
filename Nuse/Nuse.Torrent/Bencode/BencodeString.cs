namespace Nuse.Torrent.Bencode
{
    public sealed class BencodeString : IBencodeObject
    {
        private readonly string _obj;

        public string Value => _obj;

        public BencodeString()
        {
            _obj = string.Empty;
        }
        
        public BencodeString(string obj)
        {
            _obj = obj;
        }

        public override string ToString()
        {
            return $"{_obj.Length}:{_obj}";
        }
    }
}