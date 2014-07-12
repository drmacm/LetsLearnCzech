using LetsLearnCzech.Web.CzechService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsLearnCzech.Web.Models
{
    public class WordModel
    {
        public int Id { get; set; }

        [DisplayName("Foreign word")]
        [Required(ErrorMessage="Foreign word is required!")]
        public string ForeignWord { get; set; }
        
        [DisplayName("Local word")]
        [Required(ErrorMessage = "Local word is required!")]
        public string LocalWord { get; set; }
        
        [DisplayName("Processed")]
        public bool IsProcessed { get; set; }
        
        [DisplayName("Date modified")]
        public DateTime DateModified { get; set; }

        [DisplayName("Word type")]
        public virtual WordType WordType { get; set; }
    }
}