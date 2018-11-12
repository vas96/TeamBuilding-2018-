using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilding
{
    public class Connection
    {
        private static TeamBuildingEntities _Instance;

        public static TeamBuildingEntities Instance()
        {
            if (_Instance==null)
                _Instance =new TeamBuildingEntities();
            return _Instance;
        }

        private Connection()
        {   
        }

        public static Users Current = null;
    }
}
