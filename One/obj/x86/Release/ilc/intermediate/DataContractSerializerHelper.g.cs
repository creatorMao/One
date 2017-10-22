using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 885
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                866, // index: 866, string: "data"
                871, // index: 871, string: "res"
                2, // array length: 2
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                34, // array length: 34
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                475, // index: 475, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                34, // array length: 34
                875, // index: 875, string: "anchor"
                882, // index: 882, string: "audio"
                888, // index: 888, string: "audio_duration"
                903, // index: 903, string: "auth_it"
                911, // index: 911, string: "author"
                918, // index: 918, string: "author_list"
                930, // index: 930, string: "commentnum"
                941, // index: 941, string: "content_id"
                952, // index: 952, string: "copyright"
                962, // index: 962, string: "cover"
                968, // index: 968, string: "editor_email"
                981, // index: 981, string: "guide_word"
                992, // index: 992, string: "hide_flag"
                1002, // index: 1002, string: "hp_author"
                1012, // index: 1012, string: "hp_author_introduce"
                1032, // index: 1032, string: "hp_content"
                1043, // index: 1043, string: "hp_makettime"
                1056, // index: 1056, string: "hp_title"
                1065, // index: 1065, string: "last_update_date"
                1082, // index: 1082, string: "maketime"
                1091, // index: 1091, string: "next_id"
                1099, // index: 1099, string: "praisenum"
                1109, // index: 1109, string: "previous_id"
                1121, // index: 1121, string: "share_list"
                1132, // index: 1132, string: "sharenum"
                1141, // index: 1141, string: "start_video"
                1153, // index: 1153, string: "sub_title"
                1163, // index: 1163, string: "tag_list"
                1172, // index: 1172, string: "top_media_file"
                1187, // index: 1187, string: "top_media_image"
                1203, // index: 1203, string: "top_media_type"
                1218, // index: 1218, string: "wb_img_url"
                1229, // index: 1229, string: "wb_name"
                1237, // index: 1237, string: "web_url"
                34, // array length: 34
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                9, // array length: 9
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                9, // array length: 9
                1245, // index: 1245, string: "desc"
                1250, // index: 1250, string: "fans_total"
                1261, // index: 1261, string: "is_settled"
                1272, // index: 1272, string: "settled_type"
                1285, // index: 1285, string: "summary"
                1293, // index: 1293, string: "user_id"
                1301, // index: 1301, string: "user_name"
                1229, // index: 1229, string: "wb_name"
                1237, // index: 1237, string: "web_url"
                9, // array length: 9
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                9, // array length: 9
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                9, // array length: 9
                1245, // index: 1245, string: "desc"
                1250, // index: 1250, string: "fans_total"
                1261, // index: 1261, string: "is_settled"
                1272, // index: 1272, string: "settled_type"
                1285, // index: 1285, string: "summary"
                1293, // index: 1293, string: "user_id"
                1301, // index: 1301, string: "user_name"
                1229, // index: 1229, string: "wb_name"
                1237, // index: 1237, string: "web_url"
                9, // array length: 9
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                1311, // index: 1311, string: "qq"
                1314, // index: 1314, string: "weibo"
                1320, // index: 1320, string: "wx"
                1323, // index: 1323, string: "wx_timeline"
                4, // array length: 4
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                882, // index: 882, string: "audio"
                1245, // index: 1245, string: "desc"
                1335, // index: 1335, string: "imgUrl"
                1342, // index: 1342, string: "link"
                1347, // index: 1347, string: "title"
                5, // array length: 5
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                882, // index: 882, string: "audio"
                1245, // index: 1245, string: "desc"
                1335, // index: 1335, string: "imgUrl"
                1342, // index: 1342, string: "link"
                1347, // index: 1347, string: "title"
                5, // array length: 5
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                882, // index: 882, string: "audio"
                1245, // index: 1245, string: "desc"
                1335, // index: 1335, string: "imgUrl"
                1342, // index: 1342, string: "link"
                1347, // index: 1347, string: "title"
                5, // array length: 5
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                882, // index: 882, string: "audio"
                1245, // index: 1245, string: "desc"
                1335, // index: 1335, string: "imgUrl"
                1342, // index: 1342, string: "link"
                1347, // index: 1347, string: "title"
                5, // array length: 5
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                475, // index: 475, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                866, // index: 866, string: "data"
                871, // index: 871, string: "res"
                2, // array length: 2
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                866, // index: 866, string: "data"
                871, // index: 871, string: "res"
                2, // array length: 2
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                39, // array length: 39
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                475, // index: 475, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                475, // index: 475, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                39, // array length: 39
                1353, // index: 1353, string: "charge_edt"
                930, // index: 930, string: "commentnum"
                1364, // index: 1364, string: "detailcover"
                1376, // index: 1376, string: "directors"
                1386, // index: 1386, string: "directors_id"
                968, // index: 968, string: "editor_email"
                992, // index: 992, string: "hide_flag"
                1399, // index: 1399, string: "id"
                1402, // index: 1402, string: "indexcover"
                1413, // index: 1413, string: "info"
                1418, // index: 1418, string: "keywords"
                1065, // index: 1065, string: "last_update_date"
                1082, // index: 1082, string: "maketime"
                1427, // index: 1427, string: "media_type"
                1438, // index: 1438, string: "movie_id"
                1091, // index: 1091, string: "next_id"
                1447, // index: 1447, string: "officialstory"
                1461, // index: 1461, string: "photo"
                1467, // index: 1467, string: "poster"
                1099, // index: 1099, string: "praisenum"
                1109, // index: 1109, string: "previous_id"
                1474, // index: 1474, string: "read_num"
                1483, // index: 1483, string: "related"
                1491, // index: 1491, string: "releasetime"
                1503, // index: 1503, string: "review"
                1510, // index: 1510, string: "revisedscore"
                1523, // index: 1523, string: "score"
                1529, // index: 1529, string: "scoretime"
                1539, // index: 1539, string: "servertime"
                1121, // index: 1121, string: "share_list"
                1132, // index: 1132, string: "sharenum"
                1550, // index: 1550, string: "sort"
                1141, // index: 1141, string: "start_video"
                1163, // index: 1163, string: "tag_list"
                1347, // index: 1347, string: "title"
                1555, // index: 1555, string: "verse"
                1561, // index: 1561, string: "verse_en"
                1570, // index: 1570, string: "video"
                1237, // index: 1237, string: "web_url"
                39, // array length: 39
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                1311, // index: 1311, string: "qq"
                1314, // index: 1314, string: "weibo"
                1320, // index: 1320, string: "wx"
                1323, // index: 1323, string: "wx_timeline"
                4, // array length: 4
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                866, // index: 866, string: "data"
                871, // index: 871, string: "res"
                2, // array length: 2
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                1576, // index: 1576, string: "count"
                866, // index: 866, string: "data"
                2, // array length: 2
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                17, // array length: 17
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                17, // array length: 17
                875, // index: 875, string: "anchor"
                882, // index: 882, string: "audio"
                888, // index: 888, string: "audio_duration"
                918, // index: 918, string: "author_list"
                1353, // index: 1353, string: "charge_edt"
                1582, // index: 1582, string: "content"
                952, // index: 952, string: "copyright"
                968, // index: 968, string: "editor_email"
                1399, // index: 1399, string: "id"
                1590, // index: 1590, string: "input_date"
                1438, // index: 1438, string: "movie_id"
                1099, // index: 1099, string: "praisenum"
                1550, // index: 1550, string: "sort"
                1601, // index: 1601, string: "story_type"
                1285, // index: 1285, string: "summary"
                1347, // index: 1347, string: "title"
                1612, // index: 1612, string: "user"
                17, // array length: 17
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                9, // array length: 9
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                9, // array length: 9
                1245, // index: 1245, string: "desc"
                1250, // index: 1250, string: "fans_total"
                1261, // index: 1261, string: "is_settled"
                1272, // index: 1272, string: "settled_type"
                1285, // index: 1285, string: "summary"
                1293, // index: 1293, string: "user_id"
                1301, // index: 1301, string: "user_name"
                1229, // index: 1229, string: "wb_name"
                1237, // index: 1237, string: "web_url"
                9, // array length: 9
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                9, // array length: 9
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                9, // array length: 9
                1245, // index: 1245, string: "desc"
                1250, // index: 1250, string: "fans_total"
                1261, // index: 1261, string: "is_settled"
                1272, // index: 1272, string: "settled_type"
                1285, // index: 1285, string: "summary"
                1293, // index: 1293, string: "user_id"
                1301, // index: 1301, string: "user_name"
                1229, // index: 1229, string: "wb_name"
                1237, // index: 1237, string: "web_url"
                9, // array length: 9
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                866, // index: 866, string: "data"
                871, // index: 871, string: "res"
                2, // array length: 2
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                1617, // index: 1617, string: "content_list"
                1630, // index: 1630, string: "date"
                1399, // index: 1399, string: "id"
                1635, // index: 1635, string: "menu"
                1640, // index: 1640, string: "weather"
                5, // array length: 5
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                45, // array length: 45
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                475, // index: 475, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                475, // index: 475, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                45, // array length: 45
                1648, // index: 1648, string: "ad_closetime"
                1661, // index: 1661, string: "ad_id"
                1667, // index: 1667, string: "ad_linkurl"
                1678, // index: 1678, string: "ad_makettime"
                1691, // index: 1691, string: "ad_pvurl"
                1700, // index: 1700, string: "ad_pvurl_vendor"
                1716, // index: 1716, string: "ad_share_cnt"
                1729, // index: 1729, string: "ad_type"
                1737, // index: 1737, string: "audio_album"
                1749, // index: 1749, string: "audio_author"
                1762, // index: 1762, string: "audio_platform"
                1777, // index: 1777, string: "audio_url"
                911, // index: 911, string: "author"
                1787, // index: 1787, string: "bg_color"
                1796, // index: 1796, string: "category"
                1805, // index: 1805, string: "content_bgcolor"
                941, // index: 941, string: "content_id"
                1821, // index: 1821, string: "content_type"
                962, // index: 962, string: "cover"
                1834, // index: 1834, string: "display_category"
                1851, // index: 1851, string: "forward"
                1859, // index: 1859, string: "has_reading"
                1399, // index: 1399, string: "id"
                1871, // index: 1871, string: "img_url"
                1879, // index: 1879, string: "item_id"
                1065, // index: 1065, string: "last_update_date"
                1887, // index: 1887, string: "like_count"
                1898, // index: 1898, string: "movie_story_id"
                1913, // index: 1913, string: "music_name"
                1924, // index: 1924, string: "number"
                1931, // index: 1931, string: "orientation"
                1943, // index: 1943, string: "pic_info"
                1952, // index: 1952, string: "post_date"
                1962, // index: 1962, string: "serial_id"
                1972, // index: 1972, string: "serial_list"
                1984, // index: 1984, string: "share_info"
                1121, // index: 1121, string: "share_list"
                1995, // index: 1995, string: "share_url"
                1141, // index: 1141, string: "start_video"
                2005, // index: 2005, string: "subtitle"
                1163, // index: 1163, string: "tag_list"
                1347, // index: 1347, string: "title"
                2014, // index: 2014, string: "video_url"
                2024, // index: 2024, string: "volume"
                2031, // index: 2031, string: "words_info"
                45, // array length: 45
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                9, // array length: 9
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                9, // array length: 9
                1245, // index: 1245, string: "desc"
                1250, // index: 1250, string: "fans_total"
                1261, // index: 1261, string: "is_settled"
                1272, // index: 1272, string: "settled_type"
                1285, // index: 1285, string: "summary"
                1293, // index: 1293, string: "user_id"
                1301, // index: 1301, string: "user_name"
                1229, // index: 1229, string: "wb_name"
                1237, // index: 1237, string: "web_url"
                9, // array length: 9
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                1582, // index: 1582, string: "content"
                2042, // index: 2042, string: "image"
                1347, // index: 1347, string: "title"
                2048, // index: 2048, string: "url"
                4, // array length: 4
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                1311, // index: 1311, string: "qq"
                1314, // index: 1314, string: "weibo"
                1320, // index: 1320, string: "wx"
                1323, // index: 1323, string: "wx_timeline"
                4, // array length: 4
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                2052, // index: 2052, string: "list"
                2057, // index: 2057, string: "vol"
                2, // array length: 2
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                3, // array length: 3
                941, // index: 941, string: "content_id"
                1821, // index: 1821, string: "content_type"
                1347, // index: 1347, string: "title"
                3, // array length: 3
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                8, // array length: 8
                2061, // index: 2061, string: "city_name"
                2071, // index: 2071, string: "climate"
                1630, // index: 1630, string: "date"
                2079, // index: 2079, string: "humidity"
                2088, // index: 2088, string: "hurricane"
                2098, // index: 2098, string: "icons"
                2104, // index: 2104, string: "temperature"
                2116, // index: 2116, string: "wind_direction"
                8, // array length: 8
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                2131, // index: 2131, string: "day"
                2135, // index: 2135, string: "night"
                2, // array length: 2
                274, // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
                274  // index: 274, string: "http://schemas.datacontract.org/2004/07/One.Model"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=74
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                                "1d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.Article_Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyTok" +
                                "en=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.Article_AuthorList, One, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                "yToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_AuthorList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Qq, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weibo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Wx, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.WxTimeline, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Idlist, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieInfo_RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieInfo_Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieInfo_ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.MovieStory_Datum, One, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                "oken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_Datum, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.MovieStory_AuthorList, One, Version=1.0.0.0, Culture=neutral, Publi" +
                                "cKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_AuthorList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_User, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 98, // 0x62
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 321, // 0x141
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 337, // 0x151
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareInfo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 353, // 0x161
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 369, // 0x171
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Menu, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 385, // 0x181
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]," +
                                " System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 114, // 0x72
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 401, // 0x191
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weather, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 417, // 0x1a1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Icons, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 433, // 0x1b1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 130, // 0x82
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                                    "1d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                                    "1d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=28
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // Article_RootObject
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 255, // Article_RootObject
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 255, // Article_RootObject
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 4,
                    MemberNamesListIndex = 6,
                    MemberNamespacesListIndex = 9,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 324, // Article_Data
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 324, // Article_Data
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 324, // Article_Data
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 12,
                    ContractNamespacesListIndex = 47,
                    MemberNamesListIndex = 49,
                    MemberNamespacesListIndex = 84,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 359, // Article_Author
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 359, // Article_Author
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 359, // Article_Author
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 119,
                    ContractNamespacesListIndex = 129,
                    MemberNamesListIndex = 131,
                    MemberNamespacesListIndex = 141,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 400, // Article_AuthorList
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 400, // Article_AuthorList
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 400, // Article_AuthorList
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_AuthorList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_AuthorList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 151,
                    ContractNamespacesListIndex = 161,
                    MemberNamesListIndex = 163,
                    MemberNamespacesListIndex = 173,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 419, // Article_ShareList
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 419, // Article_ShareList
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 419, // Article_ShareList
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 183,
                    ContractNamespacesListIndex = 188,
                    MemberNamesListIndex = 190,
                    MemberNamespacesListIndex = 195,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 437, // Qq
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 437, // Qq
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 437, // Qq
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Qq, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Qq, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 200,
                    ContractNamespacesListIndex = 206,
                    MemberNamesListIndex = 208,
                    MemberNamespacesListIndex = 214,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 440, // Weibo
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 440, // Weibo
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 440, // Weibo
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weibo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weibo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 220,
                    ContractNamespacesListIndex = 226,
                    MemberNamesListIndex = 228,
                    MemberNamespacesListIndex = 234,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 446, // Wx
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 446, // Wx
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 446, // Wx
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Wx, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Wx, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 240,
                    ContractNamespacesListIndex = 246,
                    MemberNamesListIndex = 248,
                    MemberNamespacesListIndex = 254,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 449, // WxTimeline
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 449, // WxTimeline
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 449, // WxTimeline
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.WxTimeline, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.WxTimeline, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 260,
                    ContractNamespacesListIndex = 266,
                    MemberNamesListIndex = 268,
                    MemberNamespacesListIndex = 274,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 533, // Idlist
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 533, // Idlist
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 533, // Idlist
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Idlist, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Idlist, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 280,
                    ContractNamespacesListIndex = 283,
                    MemberNamesListIndex = 285,
                    MemberNamespacesListIndex = 288,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 554, // MovieInfo_RootObject
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 554, // MovieInfo_RootObject
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 554, // MovieInfo_RootObject
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieInfo_RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieInfo_RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 291,
                    ContractNamespacesListIndex = 294,
                    MemberNamesListIndex = 296,
                    MemberNamespacesListIndex = 299,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 575, // MovieInfo_Data
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 575, // MovieInfo_Data
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 575, // MovieInfo_Data
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieInfo_Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieInfo_Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 302,
                    ContractNamespacesListIndex = 342,
                    MemberNamesListIndex = 344,
                    MemberNamespacesListIndex = 384,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 590, // MovieInfo_ShareList
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 590, // MovieInfo_ShareList
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 590, // MovieInfo_ShareList
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieInfo_ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieInfo_ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 424,
                    ContractNamespacesListIndex = 429,
                    MemberNamesListIndex = 431,
                    MemberNamespacesListIndex = 436,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 610, // MovieStory_RootObject
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 610, // MovieStory_RootObject
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 610, // MovieStory_RootObject
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 441,
                    ContractNamespacesListIndex = 444,
                    MemberNamesListIndex = 446,
                    MemberNamespacesListIndex = 449,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 632, // MovieStory_Data
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 632, // MovieStory_Data
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 632, // MovieStory_Data
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 452,
                    ContractNamespacesListIndex = 455,
                    MemberNamesListIndex = 457,
                    MemberNamespacesListIndex = 460,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 672, // MovieStory_Datum
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 672, // MovieStory_Datum
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 672, // MovieStory_Datum
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_Datum, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_Datum, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 463,
                    ContractNamespacesListIndex = 481,
                    MemberNamesListIndex = 483,
                    MemberNamespacesListIndex = 501,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 718, // MovieStory_AuthorList
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 718, // MovieStory_AuthorList
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 718, // MovieStory_AuthorList
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_AuthorList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_AuthorList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 519,
                    ContractNamespacesListIndex = 529,
                    MemberNamesListIndex = 531,
                    MemberNamespacesListIndex = 541,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 740, // MovieStory_User
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 740, // MovieStory_User
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 740, // MovieStory_User
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_User, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_User, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 551,
                    ContractNamespacesListIndex = 561,
                    MemberNamesListIndex = 563,
                    MemberNamespacesListIndex = 573,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 756, // RootObject
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 756, // RootObject
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 756, // RootObject
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 583,
                    ContractNamespacesListIndex = 586,
                    MemberNamesListIndex = 588,
                    MemberNamespacesListIndex = 591,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 767, // Data
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 767, // Data
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 767, // Data
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 594,
                    ContractNamespacesListIndex = 600,
                    MemberNamesListIndex = 602,
                    MemberNamespacesListIndex = 608,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 791, // ContentList
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 791, // ContentList
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 791, // ContentList
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 614,
                    ContractNamespacesListIndex = 660,
                    MemberNamesListIndex = 662,
                    MemberNamespacesListIndex = 708,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 803, // Author
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 803, // Author
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 803, // Author
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 754,
                    ContractNamespacesListIndex = 764,
                    MemberNamesListIndex = 766,
                    MemberNamespacesListIndex = 776,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 810, // ShareInfo
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 810, // ShareInfo
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 810, // ShareInfo
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareInfo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareInfo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 786,
                    ContractNamespacesListIndex = 791,
                    MemberNamesListIndex = 793,
                    MemberNamespacesListIndex = 798,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 820, // ShareList
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 820, // ShareList
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 820, // ShareList
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 803,
                    ContractNamespacesListIndex = 808,
                    MemberNamesListIndex = 810,
                    MemberNamespacesListIndex = 815,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 830, // Menu
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 830, // Menu
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 830, // Menu
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Menu, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Menu, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 820,
                    ContractNamespacesListIndex = 823,
                    MemberNamesListIndex = 825,
                    MemberNamespacesListIndex = 828,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 847, // List
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 847, // List
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 847, // List
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 831,
                    ContractNamespacesListIndex = 835,
                    MemberNamesListIndex = 837,
                    MemberNamespacesListIndex = 841,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 852, // Weather
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 852, // Weather
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 852, // Weather
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weather, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weather, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 845,
                    ContractNamespacesListIndex = 854,
                    MemberNamesListIndex = 856,
                    MemberNamespacesListIndex = 865,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 860, // Icons
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 860, // Icons
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 860, // Icons
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Icons, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Icons, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 874,
                    ContractNamespacesListIndex = 877,
                    MemberNamesListIndex = 879,
                    MemberNamespacesListIndex = 882,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=9
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 337, // ArrayOfArticle_Author
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 337, // ArrayOfArticle_Author
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 337, // ArrayOfArticle_Author
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.Article_Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.Article_Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 359, // Article_Author
                    KeyNameIndex = -1,
                    ItemNameIndex = 359, // Article_Author
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 374, // ArrayOfArticle_AuthorList
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 374, // ArrayOfArticle_AuthorList
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 374, // ArrayOfArticle_AuthorList
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.Article_AuthorList, One, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                    "yToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.Article_AuthorList, One, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                    "yToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 400, // Article_AuthorList
                    KeyNameIndex = -1,
                    ItemNameIndex = 400, // Article_AuthorList
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Article_AuthorList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 460, // ArrayOfanyType
                        NamespaceIndex = 475, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 460, // ArrayOfanyType
                        StableNameNamespaceIndex = 475, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 460, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 475, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 540, // ArrayOfstring
                        NamespaceIndex = 475, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 540, // ArrayOfstring
                        StableNameNamespaceIndex = 475, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 540, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 475, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 648, // ArrayOfMovieStory_Datum
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 648, // ArrayOfMovieStory_Datum
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 648, // ArrayOfMovieStory_Datum
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.MovieStory_Datum, One, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                    "oken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.MovieStory_Datum, One, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                    "oken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 672, // MovieStory_Datum
                    KeyNameIndex = -1,
                    ItemNameIndex = 672, // MovieStory_Datum
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_Datum, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 689, // ArrayOfMovieStory_AuthorList
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 689, // ArrayOfMovieStory_AuthorList
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 689, // ArrayOfMovieStory_AuthorList
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.MovieStory_AuthorList, One, Version=1.0.0.0, Culture=neutral, Publi" +
                                    "cKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.MovieStory_AuthorList, One, Version=1.0.0.0, Culture=neutral, Publi" +
                                    "cKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 718, // MovieStory_AuthorList
                    KeyNameIndex = -1,
                    ItemNameIndex = 718, // MovieStory_AuthorList
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.MovieStory_AuthorList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 772, // ArrayOfContentList
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 772, // ArrayOfContentList
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 772, // ArrayOfContentList
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 791, // ContentList
                    KeyNameIndex = -1,
                    ItemNameIndex = 791, // ContentList
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 835, // ArrayOfList
                        NamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 835, // ArrayOfList
                        StableNameNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 835, // ArrayOfList
                        TopLevelElementNamespaceIndex = 274, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]," +
                                    " System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]," +
                                    " System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 847, // List
                    KeyNameIndex = -1,
                    ItemNameIndex = 847, // List
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 460, // ArrayOfanyType
                        NamespaceIndex = 475, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 460, // ArrayOfanyType
                        StableNameNamespaceIndex = 475, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 460, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 475, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=37
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type3.WriteArticle_RootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type2.ReadArticle_RootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type7.WriteArticle_DataToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type6.ReadArticle_DataFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type12.WriteArrayOfArticle_AuthorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type11.ReadArrayOfArticle_AuthorFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type13.ReadArrayOfArticle_AuthorFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type17.WriteArticle_AuthorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type16.ReadArticle_AuthorFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type22.WriteArrayOfArticle_AuthorListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type21.ReadArrayOfArticle_AuthorListFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type23.ReadArrayOfArticle_AuthorListFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type27.WriteArticle_AuthorListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type26.ReadArticle_AuthorListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type31.WriteArticle_ShareListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type30.ReadArticle_ShareListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type35.WriteQqToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type34.ReadQqFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type39.WriteWeiboToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type38.ReadWeiboFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type43.WriteWxToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type42.ReadWxFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type47.WriteWxTimelineToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type46.ReadWxTimelineFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type52.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type51.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type53.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type57.WriteIdlistToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type56.ReadIdlistFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type62.WriteArrayOfstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type61.ReadArrayOfstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type63.ReadArrayOfstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type67.WriteMovieInfo_RootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type66.ReadMovieInfo_RootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type71.WriteMovieInfo_DataToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type70.ReadMovieInfo_DataFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type75.WriteMovieInfo_ShareListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type74.ReadMovieInfo_ShareListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type79.WriteMovieStory_RootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type78.ReadMovieStory_RootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type83.WriteMovieStory_DataToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type82.ReadMovieStory_DataFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type88.WriteArrayOfMovieStory_DatumToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type87.ReadArrayOfMovieStory_DatumFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type89.ReadArrayOfMovieStory_DatumFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 57,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type93.WriteMovieStory_DatumToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type92.ReadMovieStory_DatumFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 58,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type98.WriteArrayOfMovieStory_AuthorListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type97.ReadArrayOfMovieStory_AuthorListFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type99.ReadArrayOfMovieStory_AuthorListFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 59,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type103.WriteMovieStory_AuthorListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type102.ReadMovieStory_AuthorListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 60,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type107.WriteMovieStory_UserToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type106.ReadMovieStory_UserFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 61,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type111.WriteRootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type110.ReadRootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 62,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type115.WriteDataToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type114.ReadDataFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 63,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type120.WriteArrayOfContentListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type119.ReadArrayOfContentListFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type121.ReadArrayOfContentListFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 64,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type125.WriteContentListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type124.ReadContentListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 65,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type129.WriteAuthorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type128.ReadAuthorFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 66,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type133.WriteShareInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type132.ReadShareInfoFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 67,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type137.WriteShareListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type136.ReadShareListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 68,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type141.WriteMenuToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type140.ReadMenuFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 69,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type146.WriteArrayOfListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type145.ReadArrayOfListFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type147.ReadArrayOfListFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 70,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type151.WriteListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type150.ReadListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 71,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type155.WriteWeatherToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type154.ReadWeatherFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 72,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type159.WriteIconsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type158.ReadIconsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 73,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type164.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type163.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type165.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','A','r','t','i','c','l','e','_','R','o','o','t','O','b','j',
            'e','c','t','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c',
            't','.','o','r','g','/','2','0','0','4','/','0','7','/','O','n','e','.','M','o','d','e','l','\0','A','r','t','i','c','l',
            'e','_','D','a','t','a','\0','A','r','r','a','y','O','f','A','r','t','i','c','l','e','_','A','u','t','h','o','r','\0','A',
            'r','t','i','c','l','e','_','A','u','t','h','o','r','\0','A','r','r','a','y','O','f','A','r','t','i','c','l','e','_','A',
            'u','t','h','o','r','L','i','s','t','\0','A','r','t','i','c','l','e','_','A','u','t','h','o','r','L','i','s','t','\0','A',
            'r','t','i','c','l','e','_','S','h','a','r','e','L','i','s','t','\0','Q','q','\0','W','e','i','b','o','\0','W','x','\0','W',
            'x','T','i','m','e','l','i','n','e','\0','A','r','r','a','y','O','f','a','n','y','T','y','p','e','\0','h','t','t','p',':',
            '/','/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1',
            '0','/','S','e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0','I','d','l','i','s','t','\0',
            'A','r','r','a','y','O','f','s','t','r','i','n','g','\0','M','o','v','i','e','I','n','f','o','_','R','o','o','t','O','b',
            'j','e','c','t','\0','M','o','v','i','e','I','n','f','o','_','D','a','t','a','\0','M','o','v','i','e','I','n','f','o','_',
            'S','h','a','r','e','L','i','s','t','\0','M','o','v','i','e','S','t','o','r','y','_','R','o','o','t','O','b','j','e','c',
            't','\0','M','o','v','i','e','S','t','o','r','y','_','D','a','t','a','\0','A','r','r','a','y','O','f','M','o','v','i','e',
            'S','t','o','r','y','_','D','a','t','u','m','\0','M','o','v','i','e','S','t','o','r','y','_','D','a','t','u','m','\0','A',
            'r','r','a','y','O','f','M','o','v','i','e','S','t','o','r','y','_','A','u','t','h','o','r','L','i','s','t','\0','M','o',
            'v','i','e','S','t','o','r','y','_','A','u','t','h','o','r','L','i','s','t','\0','M','o','v','i','e','S','t','o','r','y',
            '_','U','s','e','r','\0','R','o','o','t','O','b','j','e','c','t','\0','D','a','t','a','\0','A','r','r','a','y','O','f','C',
            'o','n','t','e','n','t','L','i','s','t','\0','C','o','n','t','e','n','t','L','i','s','t','\0','A','u','t','h','o','r','\0',
            'S','h','a','r','e','I','n','f','o','\0','S','h','a','r','e','L','i','s','t','\0','M','e','n','u','\0','A','r','r','a','y',
            'O','f','L','i','s','t','\0','L','i','s','t','\0','W','e','a','t','h','e','r','\0','I','c','o','n','s','\0','d','a','t','a',
            '\0','r','e','s','\0','a','n','c','h','o','r','\0','a','u','d','i','o','\0','a','u','d','i','o','_','d','u','r','a','t','i',
            'o','n','\0','a','u','t','h','_','i','t','\0','a','u','t','h','o','r','\0','a','u','t','h','o','r','_','l','i','s','t','\0',
            'c','o','m','m','e','n','t','n','u','m','\0','c','o','n','t','e','n','t','_','i','d','\0','c','o','p','y','r','i','g','h',
            't','\0','c','o','v','e','r','\0','e','d','i','t','o','r','_','e','m','a','i','l','\0','g','u','i','d','e','_','w','o','r',
            'd','\0','h','i','d','e','_','f','l','a','g','\0','h','p','_','a','u','t','h','o','r','\0','h','p','_','a','u','t','h','o',
            'r','_','i','n','t','r','o','d','u','c','e','\0','h','p','_','c','o','n','t','e','n','t','\0','h','p','_','m','a','k','e',
            't','t','i','m','e','\0','h','p','_','t','i','t','l','e','\0','l','a','s','t','_','u','p','d','a','t','e','_','d','a','t',
            'e','\0','m','a','k','e','t','i','m','e','\0','n','e','x','t','_','i','d','\0','p','r','a','i','s','e','n','u','m','\0','p',
            'r','e','v','i','o','u','s','_','i','d','\0','s','h','a','r','e','_','l','i','s','t','\0','s','h','a','r','e','n','u','m',
            '\0','s','t','a','r','t','_','v','i','d','e','o','\0','s','u','b','_','t','i','t','l','e','\0','t','a','g','_','l','i','s',
            't','\0','t','o','p','_','m','e','d','i','a','_','f','i','l','e','\0','t','o','p','_','m','e','d','i','a','_','i','m','a',
            'g','e','\0','t','o','p','_','m','e','d','i','a','_','t','y','p','e','\0','w','b','_','i','m','g','_','u','r','l','\0','w',
            'b','_','n','a','m','e','\0','w','e','b','_','u','r','l','\0','d','e','s','c','\0','f','a','n','s','_','t','o','t','a','l',
            '\0','i','s','_','s','e','t','t','l','e','d','\0','s','e','t','t','l','e','d','_','t','y','p','e','\0','s','u','m','m','a',
            'r','y','\0','u','s','e','r','_','i','d','\0','u','s','e','r','_','n','a','m','e','\0','q','q','\0','w','e','i','b','o','\0',
            'w','x','\0','w','x','_','t','i','m','e','l','i','n','e','\0','i','m','g','U','r','l','\0','l','i','n','k','\0','t','i','t',
            'l','e','\0','c','h','a','r','g','e','_','e','d','t','\0','d','e','t','a','i','l','c','o','v','e','r','\0','d','i','r','e',
            'c','t','o','r','s','\0','d','i','r','e','c','t','o','r','s','_','i','d','\0','i','d','\0','i','n','d','e','x','c','o','v',
            'e','r','\0','i','n','f','o','\0','k','e','y','w','o','r','d','s','\0','m','e','d','i','a','_','t','y','p','e','\0','m','o',
            'v','i','e','_','i','d','\0','o','f','f','i','c','i','a','l','s','t','o','r','y','\0','p','h','o','t','o','\0','p','o','s',
            't','e','r','\0','r','e','a','d','_','n','u','m','\0','r','e','l','a','t','e','d','\0','r','e','l','e','a','s','e','t','i',
            'm','e','\0','r','e','v','i','e','w','\0','r','e','v','i','s','e','d','s','c','o','r','e','\0','s','c','o','r','e','\0','s',
            'c','o','r','e','t','i','m','e','\0','s','e','r','v','e','r','t','i','m','e','\0','s','o','r','t','\0','v','e','r','s','e',
            '\0','v','e','r','s','e','_','e','n','\0','v','i','d','e','o','\0','c','o','u','n','t','\0','c','o','n','t','e','n','t','\0',
            'i','n','p','u','t','_','d','a','t','e','\0','s','t','o','r','y','_','t','y','p','e','\0','u','s','e','r','\0','c','o','n',
            't','e','n','t','_','l','i','s','t','\0','d','a','t','e','\0','m','e','n','u','\0','w','e','a','t','h','e','r','\0','a','d',
            '_','c','l','o','s','e','t','i','m','e','\0','a','d','_','i','d','\0','a','d','_','l','i','n','k','u','r','l','\0','a','d',
            '_','m','a','k','e','t','t','i','m','e','\0','a','d','_','p','v','u','r','l','\0','a','d','_','p','v','u','r','l','_','v',
            'e','n','d','o','r','\0','a','d','_','s','h','a','r','e','_','c','n','t','\0','a','d','_','t','y','p','e','\0','a','u','d',
            'i','o','_','a','l','b','u','m','\0','a','u','d','i','o','_','a','u','t','h','o','r','\0','a','u','d','i','o','_','p','l',
            'a','t','f','o','r','m','\0','a','u','d','i','o','_','u','r','l','\0','b','g','_','c','o','l','o','r','\0','c','a','t','e',
            'g','o','r','y','\0','c','o','n','t','e','n','t','_','b','g','c','o','l','o','r','\0','c','o','n','t','e','n','t','_','t',
            'y','p','e','\0','d','i','s','p','l','a','y','_','c','a','t','e','g','o','r','y','\0','f','o','r','w','a','r','d','\0','h',
            'a','s','_','r','e','a','d','i','n','g','\0','i','m','g','_','u','r','l','\0','i','t','e','m','_','i','d','\0','l','i','k',
            'e','_','c','o','u','n','t','\0','m','o','v','i','e','_','s','t','o','r','y','_','i','d','\0','m','u','s','i','c','_','n',
            'a','m','e','\0','n','u','m','b','e','r','\0','o','r','i','e','n','t','a','t','i','o','n','\0','p','i','c','_','i','n','f',
            'o','\0','p','o','s','t','_','d','a','t','e','\0','s','e','r','i','a','l','_','i','d','\0','s','e','r','i','a','l','_','l',
            'i','s','t','\0','s','h','a','r','e','_','i','n','f','o','\0','s','h','a','r','e','_','u','r','l','\0','s','u','b','t','i',
            't','l','e','\0','v','i','d','e','o','_','u','r','l','\0','v','o','l','u','m','e','\0','w','o','r','d','s','_','i','n','f',
            'o','\0','i','m','a','g','e','\0','u','r','l','\0','l','i','s','t','\0','v','o','l','\0','c','i','t','y','_','n','a','m','e',
            '\0','c','l','i','m','a','t','e','\0','h','u','m','i','d','i','t','y','\0','h','u','r','r','i','c','a','n','e','\0','i','c',
            'o','n','s','\0','t','e','m','p','e','r','a','t','u','r','e','\0','w','i','n','d','_','d','i','r','e','c','t','i','o','n',
            '\0','d','a','y','\0','n','i','g','h','t','\0'};
    }
}
