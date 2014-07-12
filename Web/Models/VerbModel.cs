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
        public Conjugation Conjugation { get; set; }
        
        [DisplayName("Aspect")]
        public Aspect Aspect { get; set; }
        
        [DisplayName("Person")]
        public Person Person { get; set; }

        [DisplayName("Tense")]
        public Tense Tense { get; set; }
    }
}