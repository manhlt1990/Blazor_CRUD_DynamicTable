using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tbl = Blazor.DynamicTable.Context;

namespace Blazor.DynamicTable.Servives
{
    public class DynamicTableService : IDynamicTableService
    {
        private readonly IRepository<tbl.DynamicTable> _dynamicTableRepository;
        public DynamicTableService(IRepository<tbl.DynamicTable> dynamicTableRepository)
        {
            _dynamicTableRepository = dynamicTableRepository;
        }

        public void Add(Context.DynamicTable entity)
        {
            _dynamicTableRepository.Insert(entity);
        }

        public void Delete(Context.DynamicTable entity)
        {
            _dynamicTableRepository.Update(entity);
        }

        public void Update(Context.DynamicTable entity)
        {
            _dynamicTableRepository.Update(entity);
        }

        public List<tbl.DynamicTable> GetAll()
        {
            return _dynamicTableRepository.Table.ToList();
        }

        public tbl.DynamicTable GetByTableName(string tableName)
        {
            return _dynamicTableRepository.Table.First(p => p.Name == tableName);
        }

        public tbl.DynamicTable GetByTableId(int Id)
        {
            return _dynamicTableRepository.Table.First(p => p.Id == Id);
        }
    }
}
