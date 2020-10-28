using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DynamicTable.Extensions
{
    public class TableProperty
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public bool NotNull { get; set; }
        public int MaxLenght { get; set; }
    }
}
