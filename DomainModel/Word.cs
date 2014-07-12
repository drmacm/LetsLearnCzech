using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LetsLearnCzech.DomainModel
{
    [DataContract]
    public class Word
    {
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        [Required]
        public string ForeignWord { get; set; }
        
        [DataMember]
        public string LocalWord { get; set; }
        
        [DataMember]
        public DateTime? DateModified { get; set; }
        
        [DataMember]
        public User Creator { get; set; }
        
        [DataMember]
        public bool IsProcessed { get; set; }

        [DataMember]
        public WordType WordType { get; set; }

        [DataMember]
        public Gender? ForeignGender { get; set; }
        [DataMember]
        public Gender? LocalGender { get; set; }
        [DataMember]
        public Case? Case { get; set; }


        [DataMember]
        public Conjugation? Conjugation { get; set; }
        [DataMember]
        public Aspect? Aspect { get; set; }
        [DataMember]
        public Person? Person { get; set; }
        [DataMember]
        public Tense? Tense { get; set; }
    }
}
