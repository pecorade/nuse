namespace Nuse.Torrent.Bencode
{
    public sealed class BencodeInteger : IBencodeObject
    {
        private readonly int _obj;

        public int Value => _obj;

        public BencodeInteger()
        {
            _obj = 0;
        }
        
        public BencodeInteger(int obj)
        {
            _obj = obj;
        }
        
        public override string ToString()
        {
            return $"i{_obj}e";
        }
    }
}