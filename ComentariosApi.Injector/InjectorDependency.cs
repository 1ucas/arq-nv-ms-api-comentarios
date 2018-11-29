using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComentariosApi.Models.Interfaces;
using ComentariosApi.Repos;
using ComentariosApi.Services;
using SimpleInjector;

namespace ComentariosApi.Injector
{
    public class InjectorDependency
    {
        private static Container _container;

        public static void Iniciar()
        {
            if (_container != null)
                _container.Dispose();

            _container = new Container();
            _container.Register<IComentariosService, ComentariosService>();
            _container.Register<IComentariosRepo, ComentariosRepo>();

            _container.Verify();
        }
        public static T ObterInstancia<T>() where T : class
        {
            return _container.GetInstance<T>();
        }

        public static Container Container
        {
            get
            {
                return _container;
            }
        }
    }
}