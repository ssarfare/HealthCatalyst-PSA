using Autofac;
using HealthCatalyst.PSA.DAL.Abstract;
using HealthCatalyst.PSA.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.IoC
{
    /// <summary>
    /// This class registers DAL Interface with DAL Concrete Classes
    /// </summary>
    public class DALRegister:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PersonSearchDAL>().As<IPersonSearchDAL>();
        }
    }
}
