using LetsLearnCzech.Web.CzechService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsLearnCzech.Web.Models
{
    public class VerbModel : WordModel
    {
        public override WordType WordType 
        {
            get { return WordType.Verb; }
        }

        [DisplayName("Conjugation")]
        [Range(1, int.MaxValue, ErrorMessage = "Select a correct conjugation")]
        public Conjugation Conjugation { get; set; }
        
        [DisplayName("Aspect")]
        [Range(1, int.MaxValue, ErrorMessage = "Select a correct aspect")]
        public Aspect Aspect { get; set; }
        
        [DisplayName("Person")]
        [Range(1, int.MaxValue, ErrorMessage = "Select a correct person")]
        public Person Person { get; set; }

        [DisplayName("Tense")]
        [Range(1, int.MaxValue, ErrorMessage = "Select a correct tense")]
        public Tense Tense { get; set; }
    }
}