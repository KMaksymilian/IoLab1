using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoLab1
{
    public class CitySelector
    {
        public CityConnection Connection { get; set; }
        public CitySelector()
        {
            Connection = new CityConnection();
        }

        public int Find(string v1, string v2)
        {
            if (v1 == v2) throw new ArgumentException();
            if (!Connection.IfContain((v1,v2))) throw new ArgumentException();
            return Connection.Get((v1,v2));
        }
    }
}
