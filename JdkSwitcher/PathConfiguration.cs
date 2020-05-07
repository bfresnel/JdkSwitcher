using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JdkSwitcher
{
    class PathConfiguration
    {
        public string Name { get; set; }
        public string PathValue { get; set; }

        public PathConfiguration(string name, string pathValue)
        {
            this.Name = name;
            this.PathValue = pathValue;
        }

        public override string ToString()
        {
            return this.Name + " - " + this.PathValue;
        }
    }
}
