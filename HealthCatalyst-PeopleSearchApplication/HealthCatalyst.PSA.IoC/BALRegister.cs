using Autofac;
using HealthCatalyst.PSA.BAL.Abstract;
using HealthCayalyst.PSA.BAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PSA.IoC
{
    /// <summary>
    /// This class registers BAL Interfaces to BAL Concrete Classes
    /// </summary>
    public class BALRegister:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PersonSearchManager>().As<IPersonSearchManager>();
        }
    }
}
