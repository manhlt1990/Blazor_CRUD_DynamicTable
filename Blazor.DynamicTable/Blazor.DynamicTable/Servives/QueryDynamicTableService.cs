using Blazor.DynamicTable.Context;
using Blazor.DynamicTable.Extensions;
using FastMember;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.DynamicTable.Extensions;
using tbl = Blazor.DynamicTable.Context;

namespace Blazor.DynamicTable.Servives
{
    public class QueryDynamicTableService : IQueryDynamicTableService
    {
        private readonly DynamicTableDBContext _context;
        private readonly TypeDynamicExtensions _typeDynamicExtensions;
        public QueryDynamicTableService(DynamicTableDBContext context, TypeDynamicExtensions typeDynamicExtensions)
        {
            _context = context;
            _typeDynamicExtensions = typeDynamicExtensions;
        }

        public bool CreateInstance(tbl.DynamicTable table)
        {
            var type = _typeDynamicExtensions.GetType(table.Name);
            var accessor = TypeAccessor.Create(type);
            var obj = Activator.CreateInstance(type);

            accessor[obj, "Id"] = new Random().Next(0, 1000000000);
            var _tableProperties = JsonConvert.DeserializeObject<List<TableProperty>>(table.TableProperty);
            foreach (var item in _tableProperties)
            {
                accessor[obj, item.Name] =  null;
            }
            _context.Add(obj);
            _context.Set(type);
            return true;
        }

        public List<dynamic> GetAll(string tableName)
        {
            return new List<dynamic>();
        }
    }
}
