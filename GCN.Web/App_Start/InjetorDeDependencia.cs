using GCN.Infraestrutura.InterfaceDeServicosExternos;
using GCN.Infraestrutura.ServicosExternos.PersistenciaViaEntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using Container = SimpleInjector.Container;
using GCN.Aplicacao.GestaoDeClientes;
using System.Web.Mvc;

namespace GCN.Web.App_Start
{
    public class InjetorDeDependencia
    {
        public static void Injetar()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            container.Register<Contexto, Contexto>(Lifestyle.Scoped);

            container.Register<IServicoExternoDePersistenciaViaEntityFramework, ServicoExternoDePersistenciaViaEntityFramework>(Lifestyle.Scoped);
            container.Register<IServicoDeGestaoDeClientes, ServicoDeGestaoDeClientes>(Lifestyle.Scoped);
                        
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}