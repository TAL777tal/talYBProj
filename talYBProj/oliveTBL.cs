//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace talYBProj
{
    using System;
    using System.Collections.Generic;
    
    public partial class oliveTBL
    {
        public int Id { get; set; }
        public int orderID { get; set; }
        public int dolevNum { get; set; }
        public System.DateTime currDate { get; set; }
        public int weightBruto { get; set; }
        public int weightNeto { get; set; }
        public string notes { get; set; }
        public int userID { get; set; }
        public System.DateTime orderDate { get; set; }
    
        public virtual orderTBL orderTBL { get; set; }
        public virtual userTBL userTBL { get; set; }
    }
}
