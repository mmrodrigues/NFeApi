using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NFeApiLib.NFe.CertificadoDigital
{
    /// <summary>
    /// Singleton para controle dos certificados digitais.
    /// </summary>
    public class CertificadoController
    {
        private static readonly CertificadoController instance = new CertificadoController();
        public static CertificadoController Instance => instance;
    
        private CertificadoController()
        {

        }

        /// <summary>
        /// Método para obter o certificado digital através do SerialNumber recebido
        /// </summary>
        /// <param name="serialNumber">SerialNumber do certificado desejado</param>
        /// <returns>
        /// Caso encontre o certificado digital desejado, retorna o mesmo.
        /// Caso não entre o certificado digital desejado, retorna null.
        /// </returns>
        public X509Certificate getCertificado_SerialNumber(string serialNumber)
        {
            using (var store = new X509Store(StoreLocation.CurrentUser))
            {
                store.Open(OpenFlags.MaxAllowed);
                var certs = store.Certificates.Find(X509FindType.FindBySerialNumber, serialNumber, false);
                return certs.OfType<X509Certificate>().FirstOrDefault();
            }
        }
    }
}
