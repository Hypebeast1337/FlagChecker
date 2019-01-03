using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace FlagChecker.Data.Models
{

    public class Share
    {
        [Key]
        public string Uid { get; set; }
        public DateTime Date { get; set; }
        public byte[] Countries { get; set; }
    }
}
