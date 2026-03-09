using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoLab1
{
    public class CityConnection
    {
        public Dictionary<(String, String), int> _matrix;

        public CityConnection()
        {
            _matrix = new Dictionary<(String, String), int>();
            _matrix.Add(("A", "B"), 10);
        }

        public int Get((String,String) key)
        {
            _matrix.TryGetValue(key, out var value);
            return value;
        }

        public bool IfContain((String,String) key)
        {
            return _matrix.ContainsKey(key);
        }
       
    }
}
