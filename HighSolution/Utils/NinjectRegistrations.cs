﻿
using BLL.Services;
using Interfaces.Services;
using Ninject.Modules;
using Services;

namespace HighSolution.Utils
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderService>().To<OrderService>();
            Bind<IExecutorService>().To<ExecutorService>();
            Bind<IClientService>().To<ClientService>();
            //Bind<IBookingService>().To<BookingService>();
            Bind<ITServiceService>().To<TServiceService>();
            //Bind<IServiceBookingService>().To<ServiceBookingService>();
        }
    }
}
