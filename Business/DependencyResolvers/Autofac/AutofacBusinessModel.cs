﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModel:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TasinmazManager>().As<ITasinmazService>().SingleInstance();
            builder.RegisterType<EfTasinmazDal>().As<ITasinmazDal>().SingleInstance();
            builder.RegisterType<IlManager>().As<IIlService>().SingleInstance();
            builder.RegisterType<EfIlDal>().As<IIlDal>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}