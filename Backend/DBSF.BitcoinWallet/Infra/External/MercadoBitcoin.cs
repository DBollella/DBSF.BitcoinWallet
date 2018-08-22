using System.Net.Http;
using System.Threading.Tasks;

namespace DBSF.BitcoinWallet.Infra.External
{
    public class MercadoBitcoin
    {
        static HttpClient client;

        public MercadoBitcoin()
        {
            client = new HttpClient();
        }

        public async Task<object> ResumoDiario()
        {
            HttpResponseMessage response = await client.GetAsync("https://www.mercadobitcoin.net/api/BTC/ticker/");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();           
            return responseBody;            
        }
    }
}
