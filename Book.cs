using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCSE143
{
    public partial class Book : Media<string>
    {
        public string AuthorName { get; set; }
    }
}
