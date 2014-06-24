using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct |AttributeTargets.Enum | AttributeTargets.Interface
        | AttributeTargets.Method,AllowMultiple = false)]
    public class Version: System.Attribute
    {
        public int major; //{ get; set; }
        public int minor; //{ get; set; }
        //constructor
        public Version(int minor, int major)
        {
            this.minor = minor;
            this.major = major;
        }
        
    }
}
