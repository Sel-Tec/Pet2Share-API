﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pet2Share_API.Domain
{
    [DataContract]
    public class SocialMediaSource : DomainBase
    {
        [DataMember]
        public string Name { get; set; }
    }
}
