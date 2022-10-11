using Autofac;
using Lashlift_Shop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lashlift_Shop
{
    public static class ContainerConfig
    {
        
            public static IContainer Configure()
            {
                var builder = new ContainerBuilder();

                builder.RegisterType<ViewTables>().As<IViewTables>();
                builder.RegisterType<ViewCreateGirl>().As<IViewCreateGirl>();
                builder.RegisterType<ViewCreateLashlifter>().As<IViewCreateLashlifter>();
                builder.RegisterType<ViewDeleteLashlifter>().As<IViewDeleteLashlifter>();
                builder.RegisterType<ViewDeleteGirl>().As<IViewDeleteGirl>();
                builder.RegisterType<ViewUpdateGirl>().As<IViewUpdateGirl>();
                builder.RegisterType<ViewUpdateLashlifter>().As<IViewUpdateLashlifter>();
                builder.RegisterType<ViewMainMenu>().As<IViewMainMenu>();
                builder.RegisterType<LashlifterController>().As<ILashlifterController>();
                builder.RegisterType<GirlController>().As<IGirlController>();
                builder.RegisterType<LashliftShopContext>();
                builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
                builder.RegisterType<Application>().As<IApplication>();

                return builder.Build();
            }
        



    }
}
