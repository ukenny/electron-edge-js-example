using ExternlaLibrary.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuickStart.Framework
{
    public class ExternalMethods
    {
        private readonly Library _library = new Library();

        public async Task<object> GetPersonInfo(dynamic input)
        {
            return await Task.Run(() => JsonConvert.SerializeObject(_library.GetPerson(), Formatting.Indented));
        }
    }
}
