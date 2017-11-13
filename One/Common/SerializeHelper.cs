using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace One.Common
{
    public static class JsonHelper
    {
        /// <summary>
        /// 将一个web的api 拿到json数据
        /// </summary>
        /// <param name="api">web api</param>
        /// <returns></returns>
        public static async Task<string> GetJsonStringFromWebApi(string api)
        {
            //要访问网页的api，肯定要一个httpClient
            HttpClient http = new HttpClient();

            //通过get请求，异步获取的方式，获得响应的值
            HttpResponseMessage response = await http.GetAsync(api);

            //同样是通过异步的方式，从响应的内容中，序列化到字符串的形式，到这里我们就获得了api那里拿来的json数据了。
            string resultJson = await response.Content.ReadAsStringAsync();

            return resultJson;

        }
    }
}
