
using QM.DataAccess.Concrete.EntityFrameworkCore.Context;
using QM.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using QM.DataAccess.Concrete.EntityFrameworkCore.Repositories.Users;
using QM.DataAccess.Interface;
using QM.DataAccess.Interface.Users;
using QM.DataAccess.UnitOfWorks.Interface;
using System;

namespace QM.DataAccess.UnitOfWorks.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ArlentusBIContext _Ctx;

        public IAppRoleDal appRoleDal { get; private set; }

        public IAppUserDal appUserDal { get; private set; }

       


        public UnitOfWork(ArlentusBIContext ctx)
        {
            _Ctx = ctx;

            appRoleDal = new EfAppRoleRepository(_Ctx);
            appUserDal = new EfAppUserRepository(_Ctx);
         
        }

        public void Dispose()
        {
            _Ctx.Dispose();
        }

        public void SaveChange()
        {
            try
            {
                _Ctx.SaveChanges();
            }
            catch
            {
                throw;
            }
            finally
            {

            }
        }

        IGenericDal<Table> IUnitOfWork.GetRepository<Table>()
        {
            return new EfGenericRepository<Table>(_Ctx);
        }
    }   
}
