using AccessCorp.GestaoCategoria.CrossCutting.DesignPatterns.Singletons;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace AccessCorp.GestaoCategoria.CrossCutting.ComunicacaoApi
{
    public class ChamadaApi<T> where T : class
    {
        private readonly HttpClient httpClient = null;
        private readonly string Url = null;

        public ChamadaApi()
        {
            httpClient = SigletionGeneric<HttpClient>.Instance();
            Url = ConfigurationManager.AppSettings["urlSite"].ToString();
        }

        private T Deserialize(string dataJson)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            T obj = jss.Deserialize<T>(dataJson);

            return obj;
        }

        public async Task<T> Post(string dataJson, string endPoint)
        {
            ConfigurationHttpClient();

            var response = httpClient.PostAsync(endPoint, new StringContent(dataJson, Encoding.UTF8, "application/json")).Result;

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            var resultado = (T)Deserialize(content);

            return resultado;
        }

        public async Task<T> Put(string dataJson, string endPoint)
        {
            ConfigurationHttpClient();

            var response = httpClient.PostAsync(endPoint, new StringContent(dataJson)).Result;

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            var resultado = (T)Deserialize(content);

            return resultado;
        }

        public async Task<T> Get(string dataJson, string endPoint)
        {
            ConfigurationHttpClient();

            var response = httpClient.GetAsync(endPoint).Result;

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            var resultado = (T)Deserialize(content);

            return resultado;
        }

        public async Task<T> Delete(string dataJson, string endPoint)
        {
            ConfigurationHttpClient();

            var response = httpClient.DeleteAsync(endPoint).Result;

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            var resultado = (T)Deserialize(content);

            return resultado;
        }

        private void ConfigurationHttpClient()
        {
            if (httpClient.BaseAddress == null)
            {
                httpClient.BaseAddress = new Uri(Url);
            }

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
        }
    }
}
