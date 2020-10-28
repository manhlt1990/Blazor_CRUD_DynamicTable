using Blazor.DynamicTable.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DynamicTable.ViewModel
{
    public class DynamicTableManageViewModel
    {
        public DynamicTableManageViewModel()
        {
            TableProperties = new List<TableProperty>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string TableName { get; set; }
        [Required]
        public List<TableProperty> TableProperties { get;set;}
    }
}
