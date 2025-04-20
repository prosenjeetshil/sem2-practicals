using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _28_CalculatorWebClient
{
    public partial class _Default : Page
    {
        protected async void btnCalculate_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 3;

            System.Net.ServicePointManager.Expect100Continue = false;


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44376/api/calculator/");

                HttpResponseMessage response = await client.GetAsync($"add?a={a}&b={b}");
                if (response.IsSuccessStatusCode)
                {
                    dynamic result = await response.Content.ReadAsAsync<dynamic>();
                    txtResult.Text = result.result.ToString();
                }
                else
                {
                    txtResult.Text = "Error: " + response.StatusCode;
                }
            }
        }
    }
}