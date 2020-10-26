using System;
using System.Collections.Generic;
using System.ComponentModel;
using SimpleInjector;
using SimpleInjector.Advanced;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Linq;
using System.Web;
using GCN.Infraestrutura.ServicosExternos.PersistenciaViaEntityFramework;
using Container = SimpleInjector.Container;
using GCN.Infraestrutura.InterfaceDeServicosExternos;
using System.Reflection;

namespace GCN.App_Start
{
    public class InjetorDeDependencia
    {
        public static void Injetar()
        {
            var container = new Container();

            container.Register<ContextoBase>(() => new ContextoBase());
            container.Register<IServicoExternoDePersistenciaViaEntityFramework, ServicoExternoDePersistenciaViaEntityFramework>();
        }
    }

  
}