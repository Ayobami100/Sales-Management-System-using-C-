//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int stockId { get; set; }
        public string stockName { get; set; }
        public Nullable<int> stockQuantity { get; set; }
        public string stockPack { get; set; }
        public string stockDescription { get; set; }
        public System.DateTime dateCreated { get; set; }
        public string stockPrice { get; set; }
    }
}
