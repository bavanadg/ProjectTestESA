using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models
{
    // Class for lacrimal procedure. This inherits from Procedure superclass.
    public class LacrimalModel : Procedure
    {
        public override string Name {
            get;
            set;
        }
        public override string Details {
            get;
            set;
        }
    }
}
