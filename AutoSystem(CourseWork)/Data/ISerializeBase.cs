using AutoSystem_CourseWork_.Model.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Data
{
    public interface ISerializeBase<T> where T : IEntity
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        bool Save();
        bool Load();
        Task<bool> SaveAsync();
        Task<bool> LoadAsync();
    }
}
