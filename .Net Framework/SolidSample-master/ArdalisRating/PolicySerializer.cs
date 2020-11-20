using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class PolicySerializer
    {
        public Policy GetPolicyFromJsonString(string convertJson)
        {
            return JsonConvert.DeserializeObject<Policy>(convertJson, new StringEnumConverter());
        }
    }
}
