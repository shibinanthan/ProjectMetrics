using System;
using System.Collections.Generic;
using System.Data.Linq;
//using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Tools.ProjectMetrics.DataLayer
{
    public class PMDataContext : IDisposable
    {
        DataContext dataContext = null;
        
        public PMDataContext()
        {
            dataContext = new DataContext(Constants.ConnectionString);
        }

        public void Dispose()
        {

        }
        public void SubmitChanges()
        {
            dataContext.SubmitChanges();
        }

        public Table<TEntity> GetTable<TEntity>() where TEntity : class
        {
            return dataContext.GetTable<TEntity>();
        }

    }
}
