//using Autofac;
//using DOLPHIN.Repository.UnitOfWorks;
//using DOLPHIN.Repository.UnitOfWorks.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace DOLPHIN.Modules
//{
//    public class UnitOfWorkModule : Module
//    {
//        /// <inheritdoc />
//        protected override void Load(ContainerBuilder builder)
//        {
//            builder.RegisterType(typeof(UserUnitOfWork)).As(typeof(IUserUnitOfWork)).InstancePerLifetimeScope();
//            builder.RegisterType(typeof(ProductUnitOfWork)).As(typeof(IProductUnitOfWork)).InstancePerLifetimeScope();
//            builder.RegisterType(typeof(CategoryUnitOfWork)).As(typeof(ICategoryUnitOfWork)).InstancePerLifetimeScope();
//        }
//    }
//}
