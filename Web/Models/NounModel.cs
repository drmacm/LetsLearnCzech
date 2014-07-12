using LetsLearnCzech.Web.CzechService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsLearnCzech.Web.Models
{
    public class NounModel : WordModel
    {
        public override WordType WordType
        {
            get { return WordType.Noun; }
        }

        [DisplayName("Foreign gender")]
        public Gender ForeignGender { get; set; }
        
        [DisplayName("Local gender")]
        public Gender LocalGender { get; set; }
        
        [DisplayName("Case")]
        public Case Case { get; set; }
    }
}