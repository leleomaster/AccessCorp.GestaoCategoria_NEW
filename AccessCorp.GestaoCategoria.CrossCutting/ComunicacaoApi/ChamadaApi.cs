using AccessCorp.GestaoCategoria.CrossCutting.DesignPatterns.Singletons;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
            try
            {

                var response = httpClient.PostAsync(endPoint, new StringContent(dataJson)).Result;

                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();

                return await Task.Run(() => Deserialize(content));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<T> Put(string dataJson, string endPoint)
        {
            ConfigurationHttpClient();

            var response = httpClient.PostAsync(endPoint, new StringContent(dataJson)).Result;

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return await Task.Run(() => Deserialize(content));
        }

        public async Task<T> Get(string dataJson, string endPoint)
        {
            ConfigurationHttpClient();

            var response = httpClient.GetAsync(endPoint).Result;

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return await Task.Run(() => Deserialize(content));
        }

        public async Task<T> Delete(string dataJson, string endPoint)
        {
            ConfigurationHttpClient();

            var response = httpClient.DeleteAsync(endPoint).Result;

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return await Task.Run(() => Deserialize(content));
        }


        private void ConfigurationHttpClient()
        {
            httpClient.BaseAddress = new Uri(Url);

            httpClient.DefaultRequestHeaders.Accept.Clear();

            // adicionando um Accept header para o formato JSON.
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
