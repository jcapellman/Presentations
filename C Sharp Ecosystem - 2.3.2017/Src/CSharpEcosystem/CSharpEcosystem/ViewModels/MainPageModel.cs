using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace CSharpEcosystem.ViewModels
{
    public class MainPageModel : BaseModel
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; OnPropertyChanged(); }
        }

        public bool LoadData()
        {
            /*
            var httpClient = new HttpClient();

            var jsonString = await httpClient.GetStringAsync("http://localhost:55665/api/Account");

            Message = (string)JsonConvert.DeserializeObject(jsonString);
            */

            Message = "Hello World";

            return true;
        }
    }
}