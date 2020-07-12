using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace HabrHtmlParser.Core
{
    class HtmlLoader
    {
        readonly HttpClient clients;
        readonly string url;
        public HtmlLoader(IParserSettings settings)
        {
            clients = new HttpClient();
            url = $"{settings.BaseUrl}/{settings.Prefix}/";
        }
        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{CurrentId}", id.ToString());
            var response = await clients.GetAsync(currentUrl);
            string source = null;

            if(response !=null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
