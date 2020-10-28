using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DynamicTable.Context
{
    public class DynamicTable
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string TableName { get; set; }
        [MaxLength(2000)]
        public string TableProperty { get; set; }
    }
}
