using Ninject.Modules;
using OnionApp.Domain.Interfaces;
using OnionApp.Infrastructure.Business;
using OnionApp.Services.Interfaces;
using OnionApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnionApp.Web.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookRepository>().To<BookRepository>();
            Bind<IOrder>().To<CacheOrder>();
        }
    }
}