using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.DynamicTable.Context;
using tbl = Blazor.DynamicTable.Context;

namespace Blazor.DynamicTable.Servives
{
    public interface IDynamicTableService
    {
        void Add(tbl.DynamicTable entity);
        void Update(tbl.DynamicTable entity);
        void Delete(tbl.DynamicTable entity);
        List<tbl.DynamicTable> GetAll();
        tbl.DynamicTable GetByTableName(string tableName);
        tbl.DynamicTable GetByTableId(int Id);
    }
}
