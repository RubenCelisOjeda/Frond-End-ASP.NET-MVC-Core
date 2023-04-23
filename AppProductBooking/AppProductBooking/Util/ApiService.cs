using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AppProductBooking.Util
{
    public class ApiService
    {
        #region [Properties]
        /// <summary>
        /// <param name="_mediaType">Tipo de datos por la cual se enviaran los datos</param>
        /// <param name="_serviceUrl">Direccion URL del Servicio Rest proporcionado>
        /// <returns>Retorna los datos de la persona con el ingreso que se encontro.</returns>
        private const string _mediaType = "application/json";

        #region [ApiUrl]
        private static readonly string ApiUrlBase = "https://localhost:44327/api/";
        #endregion

        #endregion

        #region [Constructor]
        public ApiService()
        {

        }
        #endregion

        #region [Api Service]
        /// <summary>
        /// Devuelve una Lista Generica con los datos solicitado desde la URL que se especifico
        /// </summary>
        /// <param name="pPath">Ruta interna del servicio</param>
        /// <returns>Retorna los datos de la entidad.</returns>
        public static T GetAsync<T>(string pPath)
        {
            try
            {
                var responseBody = string.Empty;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ApiUrlBase);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(_mediaType));

                    var response = client.GetAsync(pPath).Result;

                    response.EnsureSuccessStatusCode();
                    responseBody = response.Content.ReadAsStringAsync().Result;
                }

                var list = JsonConvert.DeserializeObject<T>(responseBody);
                return list;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("RestClient.GetAsync error " + ex.Message);
            }
        }


        /// <summary>
        /// Envia los datos de la entidad para ser guardado
        /// </summary>
        /// <param name="pPath">Ruta interna del servicio</param>
        /// <param name="pObj">Objeto de datos</param>
        /// <returns>Retorna mensaje de confirmacion.</returns>
        public static T PostAsync<T>(string pPath, object pObj)
        {
            try
            {
                var responseBody = string.Empty;
                T item;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ApiUrlBase);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(_mediaType));

                    var postBody = new StringContent(JsonConvert.SerializeObject(pObj).ToString(),
                        Encoding.UTF8, "application/json");

                    var response = client.PostAsync(pPath, postBody).Result;
                    response.EnsureSuccessStatusCode();
                    responseBody = response.Content.ReadAsStringAsync().Result;
                }
                item = JsonConvert.DeserializeObject<T>(responseBody);
                return item;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("RestClient.GetAsync error " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina los datos de la entidad  
        /// </summary>
        /// <param name="pPath">Ruta interna del servicio</param>
        /// <param name="pObj">Objeto de datos</param>
        /// <returns>Retorna mensaje de confirmacion.</returns>
        public static T DeleteAsync<T>(string path)
        {
            try
            {
                var responseBody = string.Empty;
                T item;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ApiUrlBase);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(_mediaType));

                    var response = client.DeleteAsync(path).Result;
                    response.EnsureSuccessStatusCode();
                    responseBody = response.Content.ReadAsStringAsync().Result;
                }

                item = JsonConvert.DeserializeObject<T>(responseBody);
                return item;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("RestClient.GetAsync error " + ex.Message);
            }
        } 
        #endregion
    }
}
