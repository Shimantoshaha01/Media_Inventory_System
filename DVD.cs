using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCSE143
{
    public partial class DVD : Media<string>
    {
        public string DirectorName { get; set; }
    }
}
