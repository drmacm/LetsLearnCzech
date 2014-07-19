using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LetsLearnCzech.DomainModel
{
    [DataContract]
    public class SimpleWord
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string ForeignWord { get; set; }

        [DataMember]
        public string LocalWord { get; set; }
    }
}
