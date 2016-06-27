using System;
using System.Runtime.Serialization;

namespace WhichShouldYouUse.Benchmarks.Enums.ObjectEnumVsRegular.Regular
{
    [DataContract]
    [Serializable]
    public class Location
    {
        [DataMember]
        public StreetTypes StreetTypes { get; set; }
    }
}