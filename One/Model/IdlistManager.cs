using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.IO;

namespace One.Model
{
    /// <summary>
    /// 每日id管理类（10天）
    /// </summary>
    public static class IdlistManager
    {
        public static async Task<Idlist> GetIdlist()
        {
            //要访问网页的api，肯定要一个httpClient
            HttpClient http = new HttpClient();

            //通过get请求，异步获取的方式，获得响应的值
            HttpResponseMessage response = await http.GetAsync("http://v3.wufazhuce.com:8000/api/onelist/idlist/?channel=mi&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android");

            //同样是通过异步的方式，从响应的内容中，序列化到字符串的形式，到这里我们就获得了api那里拿来的json数据了。
            string resultJson = await response.Content.ReadAsStringAsync();

            //我们用DataContractJsonSerializer作为反序列化的工具
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Idlist));

            //???
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resultJson));

            Idlist data = (Idlist)serializer.ReadObject(ms);

            return data;
        }
    }

    /// <summary>
    /// 每日id类（10天）
    /// </summary>
    [DataContract]
    public class Idlist
    {
        /// <summary>
        /// 结果值
        /// </summary>
        [DataMember]
        public int res { get; set; }
        /// <summary>
        /// 每日id列表
        /// </summary>
        [DataMember]
        public List<string> data { get; set; }
    }
}
