using System;
namespace RevStackCore.GoogleApis.Core
{
    public class GoogleApiContext
    {
        private string _key { get; set; }
        public string Key
        {
            get
            {
                return _key;
            }
        }
        public GoogleApiContext(string key)
        {
            _key = key;
        }
    }
}
