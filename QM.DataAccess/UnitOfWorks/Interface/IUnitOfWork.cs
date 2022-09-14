using QM.DataAccess.Interface;
using QM.DataAccess.Interface.Users;
using QM.Entities.Interface;
using System;

namespace QM.DataAccess.UnitOfWorks.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IAppRoleDal appRoleDal { get; }

        IAppUserDal appUserDal { get; }

       

        IGenericDal<Table> GetRepository<Table>() where Table : class, ITable, new();

        void SaveChange();
    }
}
