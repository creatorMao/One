using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace One.Common
{
    public static class SerializeHelper
    {
        /// <summary>
        /// 从一个web的api中拿到string类型的json数据
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


        /// <summary>
        /// 将一个json数据，反序列化成你要的类型
        /// </summary>
        /// <typeparam name="T">目标类型，反序列化后的类型</typeparam>
        /// <param name="jsonString">json数据</param>
        /// <returns></returns>
        public static T DeSerialize<T>(string jsonString)
        {
            T result;
            result = JsonConvert.DeserializeObject<T>(jsonString);
            return result;
        }


        /// <summary>
        /// 将一个实例序列化
        /// </summary>
        /// <param name="value">要被序列化的实例</param>
        /// <returns>序列化的结果 返回一个string类型的数据</returns>
        public static string Serialize(object value)
        {
            string result;
            result = JsonConvert.SerializeObject(value);
            return result;
        }
    }
}
