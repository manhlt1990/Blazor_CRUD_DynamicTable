using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tbl = Blazor.DynamicTable.Context;

namespace Blazor.DynamicTable.Servives
{
    public interface IQueryDynamicTableService
    {
        public bool CreateInstance(tbl.DynamicTable table);
        List<dynamic> GetAll(string tableName);
    }
}
