﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Backlog4net.Internal.Json
{
    public class IssueTypeJsonImpl : IssueType
    {
        internal class JsonConverter : InterfaceConverter<IssueType, IssueTypeJsonImpl> { }

        [JsonProperty]
        public long Id { get; private set; }

        [JsonProperty]
        public long ProjectId { get; private set; }

        [JsonProperty]
        public string Name { get; private set; }

        [JsonProperty]
        public string Color { get; private set; }

        [JsonProperty]
        public long DisplayOrder { get; private set; }
    }
}
