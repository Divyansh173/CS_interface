using CS_Gen_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Models
{
    /// <summary>
    /// The 'in' means input parameter 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPk"></typeparam>
    public interface IDbOperations<TEntity, in TPk> where TEntity : Staff
    {
        Dictionary<int, Staff> GetAll();
        void Create(int id,TEntity entity);
        Dictionary<int, Staff> Update(TPk id, TEntity entity);
        Dictionary<int, Staff> Delete(TPk id);
    }

}