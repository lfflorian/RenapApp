using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wsRenap
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Certificado" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Certificado.svc o Certificado.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Certificado : ICertificado
    {
        void ICertificado.Certificado(string CUI)
        {
            throw new NotImplementedException();
        }
    }
}
