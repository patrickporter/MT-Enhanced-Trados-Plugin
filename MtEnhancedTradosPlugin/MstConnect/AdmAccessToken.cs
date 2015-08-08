using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Web;
using System.ServiceModel.Channels;
using System.ServiceModel;
using MstTranslateConnect;

namespace MstTranslateConnect
{
    [DataContract]
    internal class AdmAccessToken
    {
        [DataMember]
        internal string access_token { get; set; }
        [DataMember]
        internal string token_type { get; set; }
        [DataMember]
        internal string expires_in { get; set; }
        [DataMember]
        internal string scope { get; set; }

    }
}
