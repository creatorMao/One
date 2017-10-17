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
        // Count = 394
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                2, // array length: 2
                326, // index: 326, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                532, // index: 532, string: "data"
                537, // index: 537, string: "res"
                2, // array length: 2
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                532, // index: 532, string: "data"
                537, // index: 537, string: "res"
                2, // array length: 2
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                541, // index: 541, string: "content_list"
                554, // index: 554, string: "date"
                559, // index: 559, string: "id"
                562, // index: 562, string: "menu"
                567, // index: 567, string: "weather"
                5, // array length: 5
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
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
                326, // index: 326, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                326, // index: 326, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                45, // array length: 45
                575, // index: 575, string: "ad_closetime"
                588, // index: 588, string: "ad_id"
                594, // index: 594, string: "ad_linkurl"
                605, // index: 605, string: "ad_makettime"
                618, // index: 618, string: "ad_pvurl"
                627, // index: 627, string: "ad_pvurl_vendor"
                643, // index: 643, string: "ad_share_cnt"
                656, // index: 656, string: "ad_type"
                664, // index: 664, string: "audio_album"
                676, // index: 676, string: "audio_author"
                689, // index: 689, string: "audio_platform"
                704, // index: 704, string: "audio_url"
                714, // index: 714, string: "author"
                721, // index: 721, string: "bg_color"
                730, // index: 730, string: "category"
                739, // index: 739, string: "content_bgcolor"
                755, // index: 755, string: "content_id"
                766, // index: 766, string: "content_type"
                779, // index: 779, string: "cover"
                785, // index: 785, string: "display_category"
                802, // index: 802, string: "forward"
                810, // index: 810, string: "has_reading"
                559, // index: 559, string: "id"
                822, // index: 822, string: "img_url"
                830, // index: 830, string: "item_id"
                838, // index: 838, string: "last_update_date"
                855, // index: 855, string: "like_count"
                866, // index: 866, string: "movie_story_id"
                881, // index: 881, string: "music_name"
                892, // index: 892, string: "number"
                899, // index: 899, string: "orientation"
                911, // index: 911, string: "pic_info"
                920, // index: 920, string: "post_date"
                930, // index: 930, string: "serial_id"
                940, // index: 940, string: "serial_list"
                952, // index: 952, string: "share_info"
                963, // index: 963, string: "share_list"
                974, // index: 974, string: "share_url"
                984, // index: 984, string: "start_video"
                996, // index: 996, string: "subtitle"
                1005, // index: 1005, string: "tag_list"
                1014, // index: 1014, string: "title"
                1020, // index: 1020, string: "video_url"
                1030, // index: 1030, string: "volume"
                1037, // index: 1037, string: "words_info"
                45, // array length: 45
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
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
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                9, // array length: 9
                1048, // index: 1048, string: "desc"
                1053, // index: 1053, string: "fans_total"
                1064, // index: 1064, string: "is_settled"
                1075, // index: 1075, string: "settled_type"
                1088, // index: 1088, string: "summary"
                1096, // index: 1096, string: "user_id"
                1104, // index: 1104, string: "user_name"
                1114, // index: 1114, string: "wb_name"
                1122, // index: 1122, string: "web_url"
                9, // array length: 9
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                1130, // index: 1130, string: "content"
                1138, // index: 1138, string: "image"
                1014, // index: 1014, string: "title"
                1144, // index: 1144, string: "url"
                4, // array length: 4
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                4, // array length: 4
                1148, // index: 1148, string: "qq"
                1151, // index: 1151, string: "weibo"
                1157, // index: 1157, string: "wx"
                1160, // index: 1160, string: "wx_timeline"
                4, // array length: 4
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                1172, // index: 1172, string: "audio"
                1048, // index: 1048, string: "desc"
                1178, // index: 1178, string: "imgUrl"
                1185, // index: 1185, string: "link"
                1014, // index: 1014, string: "title"
                5, // array length: 5
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                1172, // index: 1172, string: "audio"
                1048, // index: 1048, string: "desc"
                1178, // index: 1178, string: "imgUrl"
                1185, // index: 1185, string: "link"
                1014, // index: 1014, string: "title"
                5, // array length: 5
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                1172, // index: 1172, string: "audio"
                1048, // index: 1048, string: "desc"
                1178, // index: 1178, string: "imgUrl"
                1185, // index: 1185, string: "link"
                1014, // index: 1014, string: "title"
                5, // array length: 5
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                5, // array length: 5
                1172, // index: 1172, string: "audio"
                1048, // index: 1048, string: "desc"
                1178, // index: 1178, string: "imgUrl"
                1185, // index: 1185, string: "link"
                1014, // index: 1014, string: "title"
                5, // array length: 5
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                1190, // index: 1190, string: "list"
                1195, // index: 1195, string: "vol"
                2, // array length: 2
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                3, // array length: 3
                755, // index: 755, string: "content_id"
                766, // index: 766, string: "content_type"
                1014, // index: 1014, string: "title"
                3, // array length: 3
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
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
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                8, // array length: 8
                1199, // index: 1199, string: "city_name"
                1209, // index: 1209, string: "climate"
                554, // index: 554, string: "date"
                1217, // index: 1217, string: "humidity"
                1226, // index: 1226, string: "hurricane"
                1236, // index: 1236, string: "icons"
                1242, // index: 1242, string: "temperature"
                1254, // index: 1254, string: "wind_direction"
                8, // array length: 8
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                2, // array length: 2
                1269, // index: 1269, string: "day"
                1273, // index: 1273, string: "night"
                2, // array length: 2
                262, // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
                262  // index: 262, string: "http://schemas.datacontract.org/2004/07/One.Model"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=57
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
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
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
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Idlist, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareInfo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Qq, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weibo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Wx, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.WxTimeline, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Menu, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]," +
                                " System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weather, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Icons, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
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
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
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
        // Count=15
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // Idlist
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 255, // Idlist
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 255, // Idlist
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Idlist, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Idlist, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
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
                        NameIndex = 384, // RootObject
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 384, // RootObject
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 384, // RootObject
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.RootObject, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 12,
                    ContractNamespacesListIndex = 15,
                    MemberNamesListIndex = 17,
                    MemberNamespacesListIndex = 20,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 395, // Data
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 395, // Data
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 395, // Data
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Data, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 23,
                    ContractNamespacesListIndex = 29,
                    MemberNamesListIndex = 31,
                    MemberNamespacesListIndex = 37,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 419, // ContentList
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 419, // ContentList
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 419, // ContentList
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 43,
                    ContractNamespacesListIndex = 89,
                    MemberNamesListIndex = 91,
                    MemberNamespacesListIndex = 137,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 431, // Author
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 431, // Author
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 431, // Author
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Author, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 183,
                    ContractNamespacesListIndex = 193,
                    MemberNamesListIndex = 195,
                    MemberNamespacesListIndex = 205,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 453, // ShareInfo
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 453, // ShareInfo
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 453, // ShareInfo
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareInfo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareInfo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 215,
                    ContractNamespacesListIndex = 220,
                    MemberNamesListIndex = 222,
                    MemberNamespacesListIndex = 227,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 463, // ShareList
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 463, // ShareList
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 463, // ShareList
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ShareList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 232,
                    ContractNamespacesListIndex = 237,
                    MemberNamesListIndex = 239,
                    MemberNamespacesListIndex = 244,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 473, // Qq
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 473, // Qq
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 473, // Qq
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Qq, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Qq, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 249,
                    ContractNamespacesListIndex = 255,
                    MemberNamesListIndex = 257,
                    MemberNamespacesListIndex = 263,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 476, // Weibo
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 476, // Weibo
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 476, // Weibo
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weibo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weibo, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 269,
                    ContractNamespacesListIndex = 275,
                    MemberNamesListIndex = 277,
                    MemberNamespacesListIndex = 283,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 482, // Wx
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 482, // Wx
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 482, // Wx
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Wx, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Wx, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 289,
                    ContractNamespacesListIndex = 295,
                    MemberNamesListIndex = 297,
                    MemberNamespacesListIndex = 303,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 485, // WxTimeline
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 485, // WxTimeline
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 485, // WxTimeline
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.WxTimeline, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.WxTimeline, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 309,
                    ContractNamespacesListIndex = 315,
                    MemberNamesListIndex = 317,
                    MemberNamespacesListIndex = 323,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 496, // Menu
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 496, // Menu
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 496, // Menu
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Menu, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Menu, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 329,
                    ContractNamespacesListIndex = 332,
                    MemberNamesListIndex = 334,
                    MemberNamespacesListIndex = 337,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 513, // List
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 513, // List
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 513, // List
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 340,
                    ContractNamespacesListIndex = 344,
                    MemberNamesListIndex = 346,
                    MemberNamespacesListIndex = 350,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 518, // Weather
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 518, // Weather
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 518, // Weather
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weather, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Weather, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 354,
                    ContractNamespacesListIndex = 363,
                    MemberNamesListIndex = 365,
                    MemberNamespacesListIndex = 374,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 526, // Icons
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 526, // Icons
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 526, // Icons
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Icons, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.Icons, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 383,
                    ContractNamespacesListIndex = 386,
                    MemberNamesListIndex = 388,
                    MemberNamespacesListIndex = 391,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=5
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 312, // ArrayOfstring
                        NamespaceIndex = 326, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 312, // ArrayOfstring
                        StableNameNamespaceIndex = 326, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 312, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 326, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
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
                        NameIndex = 400, // ArrayOfContentList
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 400, // ArrayOfContentList
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 400, // ArrayOfContentList
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 419, // ContentList
                    KeyNameIndex = -1,
                    ItemNameIndex = 419, // ContentList
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.ContentList, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 438, // ArrayOfanyType
                        NamespaceIndex = 326, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 438, // ArrayOfanyType
                        StableNameNamespaceIndex = 326, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 438, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 326, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
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
                        NameIndex = 501, // ArrayOfList
                        NamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        StableNameIndex = 501, // ArrayOfList
                        StableNameNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        TopLevelElementNameIndex = 501, // ArrayOfList
                        TopLevelElementNamespaceIndex = 262, // http://schemas.datacontract.org/2004/07/One.Model
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]," +
                                    " System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]," +
                                    " System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 513, // List
                    KeyNameIndex = -1,
                    ItemNameIndex = 513, // List
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("One.Model.List, One, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 438, // ArrayOfanyType
                        NamespaceIndex = 326, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 438, // ArrayOfanyType
                        StableNameNamespaceIndex = 326, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 438, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 326, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
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
        // Count=20
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type3.WriteIdlistToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type2.ReadIdlistFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type8.WriteArrayOfstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type7.ReadArrayOfstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type9.ReadArrayOfstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type13.WriteRootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type12.ReadRootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type17.WriteDataToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type16.ReadDataFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type22.WriteArrayOfContentListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type21.ReadArrayOfContentListFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type23.ReadArrayOfContentListFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type27.WriteContentListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type26.ReadContentListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type31.WriteAuthorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type30.ReadAuthorFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type36.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type35.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type37.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type41.WriteShareInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type40.ReadShareInfoFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type45.WriteShareListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type44.ReadShareListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type49.WriteQqToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type48.ReadQqFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type53.WriteWeiboToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type52.ReadWeiboFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type57.WriteWxToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type56.ReadWxFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type61.WriteWxTimelineToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type60.ReadWxTimelineFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type65.WriteMenuToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type64.ReadMenuFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type70.WriteArrayOfListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type69.ReadArrayOfListFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type71.ReadArrayOfListFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type75.WriteListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type74.ReadListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type79.WriteWeatherToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type78.ReadWeatherFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type83.WriteIconsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type82.ReadIconsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type88.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type87.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type89.ReadArrayOfanyTypeFromJsonIsGetOnly),
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
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','I','d','l','i','s','t','\0','h','t','t','p',':','/','/','s',
            'c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0',
            '7','/','O','n','e','.','M','o','d','e','l','\0','A','r','r','a','y','O','f','s','t','r','i','n','g','\0','h','t','t','p',
            ':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0','3','/',
            '1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0','R','o','o','t','O','b',
            'j','e','c','t','\0','D','a','t','a','\0','A','r','r','a','y','O','f','C','o','n','t','e','n','t','L','i','s','t','\0','C',
            'o','n','t','e','n','t','L','i','s','t','\0','A','u','t','h','o','r','\0','A','r','r','a','y','O','f','a','n','y','T','y',
            'p','e','\0','S','h','a','r','e','I','n','f','o','\0','S','h','a','r','e','L','i','s','t','\0','Q','q','\0','W','e','i','b',
            'o','\0','W','x','\0','W','x','T','i','m','e','l','i','n','e','\0','M','e','n','u','\0','A','r','r','a','y','O','f','L','i',
            's','t','\0','L','i','s','t','\0','W','e','a','t','h','e','r','\0','I','c','o','n','s','\0','d','a','t','a','\0','r','e','s',
            '\0','c','o','n','t','e','n','t','_','l','i','s','t','\0','d','a','t','e','\0','i','d','\0','m','e','n','u','\0','w','e','a',
            't','h','e','r','\0','a','d','_','c','l','o','s','e','t','i','m','e','\0','a','d','_','i','d','\0','a','d','_','l','i','n',
            'k','u','r','l','\0','a','d','_','m','a','k','e','t','t','i','m','e','\0','a','d','_','p','v','u','r','l','\0','a','d','_',
            'p','v','u','r','l','_','v','e','n','d','o','r','\0','a','d','_','s','h','a','r','e','_','c','n','t','\0','a','d','_','t',
            'y','p','e','\0','a','u','d','i','o','_','a','l','b','u','m','\0','a','u','d','i','o','_','a','u','t','h','o','r','\0','a',
            'u','d','i','o','_','p','l','a','t','f','o','r','m','\0','a','u','d','i','o','_','u','r','l','\0','a','u','t','h','o','r',
            '\0','b','g','_','c','o','l','o','r','\0','c','a','t','e','g','o','r','y','\0','c','o','n','t','e','n','t','_','b','g','c',
            'o','l','o','r','\0','c','o','n','t','e','n','t','_','i','d','\0','c','o','n','t','e','n','t','_','t','y','p','e','\0','c',
            'o','v','e','r','\0','d','i','s','p','l','a','y','_','c','a','t','e','g','o','r','y','\0','f','o','r','w','a','r','d','\0',
            'h','a','s','_','r','e','a','d','i','n','g','\0','i','m','g','_','u','r','l','\0','i','t','e','m','_','i','d','\0','l','a',
            's','t','_','u','p','d','a','t','e','_','d','a','t','e','\0','l','i','k','e','_','c','o','u','n','t','\0','m','o','v','i',
            'e','_','s','t','o','r','y','_','i','d','\0','m','u','s','i','c','_','n','a','m','e','\0','n','u','m','b','e','r','\0','o',
            'r','i','e','n','t','a','t','i','o','n','\0','p','i','c','_','i','n','f','o','\0','p','o','s','t','_','d','a','t','e','\0',
            's','e','r','i','a','l','_','i','d','\0','s','e','r','i','a','l','_','l','i','s','t','\0','s','h','a','r','e','_','i','n',
            'f','o','\0','s','h','a','r','e','_','l','i','s','t','\0','s','h','a','r','e','_','u','r','l','\0','s','t','a','r','t','_',
            'v','i','d','e','o','\0','s','u','b','t','i','t','l','e','\0','t','a','g','_','l','i','s','t','\0','t','i','t','l','e','\0',
            'v','i','d','e','o','_','u','r','l','\0','v','o','l','u','m','e','\0','w','o','r','d','s','_','i','n','f','o','\0','d','e',
            's','c','\0','f','a','n','s','_','t','o','t','a','l','\0','i','s','_','s','e','t','t','l','e','d','\0','s','e','t','t','l',
            'e','d','_','t','y','p','e','\0','s','u','m','m','a','r','y','\0','u','s','e','r','_','i','d','\0','u','s','e','r','_','n',
            'a','m','e','\0','w','b','_','n','a','m','e','\0','w','e','b','_','u','r','l','\0','c','o','n','t','e','n','t','\0','i','m',
            'a','g','e','\0','u','r','l','\0','q','q','\0','w','e','i','b','o','\0','w','x','\0','w','x','_','t','i','m','e','l','i','n',
            'e','\0','a','u','d','i','o','\0','i','m','g','U','r','l','\0','l','i','n','k','\0','l','i','s','t','\0','v','o','l','\0','c',
            'i','t','y','_','n','a','m','e','\0','c','l','i','m','a','t','e','\0','h','u','m','i','d','i','t','y','\0','h','u','r','r',
            'i','c','a','n','e','\0','i','c','o','n','s','\0','t','e','m','p','e','r','a','t','u','r','e','\0','w','i','n','d','_','d',
            'i','r','e','c','t','i','o','n','\0','d','a','y','\0','n','i','g','h','t','\0'};
    }
}
