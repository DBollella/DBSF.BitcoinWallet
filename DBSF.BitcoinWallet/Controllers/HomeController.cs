using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBSF.BitcoinWallet.Infra.External;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DBSF.BitcoinWallet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private MercadoBitcoin objMercadoBitcoin;

        public HomeController()
        {
            //TODO: Implementar Injeção Dependencia
            objMercadoBitcoin = new MercadoBitcoin();
        }


        [HttpGet]
        public ActionResult<string> ResumoDiario()
        {
            var retorno = string.Empty;
            try
            {
                retorno = objMercadoBitcoin.ResumoDiario().Result.ToString();   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
            return retorno;
        }   
    }
}
