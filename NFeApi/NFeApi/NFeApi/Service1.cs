using NFeApiLib.NFe.CertificadoDigital;
using NFeApiLib.NFe.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace NFeApi
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Process();
        }

        protected override void OnStop()
        {
        }

        public void Process()
        {
            var cert = CertificadoController.Instance.getCertificado_SerialNumber("313838");
            var obj = new TConsSitNFe("31181209339936000973550330000930221088758563");
            var xml = obj.SerializeObject();

            return;
        }
    }
}
