//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceWIki.Models.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class EditInfo
    {
        public EditInfo()
        {
            dayCreateEI = DateTime.Now;
        }
        public int idEI { get; set; }
        public int idInfo { get; set; }
        public string contentEdit { get; set; }
        public System.DateTime dayCreateEI { get; set; }
        public int idUser { get; set; }
        public bool newEI { get; set; }
    
        public virtual Information Information { get; set; }
        public virtual User User { get; set; }
    }
}
