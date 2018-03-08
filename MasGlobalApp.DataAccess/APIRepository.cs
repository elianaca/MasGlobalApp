using MasGlobalApp.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalApp.DataAccess
{
    public class APIRepository
    {

        /// <summary>
        /// Gets the employees asynchronous.
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://masglobaltestapi.azurewebsites.net/api/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = client.GetAsync("Employees").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonEmployees = response.Content.ReadAsStringAsync();
                        jsonEmployees.Wait();
                        employees = JsonConvert.DeserializeObject<List<Employee>>(jsonEmployees.Result);
                    }
                }

                return employees;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
