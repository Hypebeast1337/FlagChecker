using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace FlagChecker.Data.Models
{
    [ProtoContract]
    public class Country
    {
        [ProtoMember(1)]
        public string NameEn { get; set; }
        [ProtoMember(2)]
        public string NamePl { get; set; }
        [ProtoMember(3)]
        public string Code { get; set; }
        [ProtoMember(4)]
        public int Id { get; set; }
        [ProtoMember(5)]
        public string Source { get; set; }
        [ProtoMember(6)]
        public string Continent { get; set; }
        [ProtoMember(7)]
        public int Area { get; set; }
    }
}
