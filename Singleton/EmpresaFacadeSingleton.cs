using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get { return facade}
        }


    }
}
