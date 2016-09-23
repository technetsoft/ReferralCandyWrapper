﻿using Newtonsoft.Json;

namespace ReferralCandyWrapper.Messages
{
    public class Response
    {
        [JsonIgnore]
        public int HttpCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messagereferralcorner_url")]
        public string ReferralCornerUrl { get; set; }
    }
}
