//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenSky.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class os_invoices_detail
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> InvoicesHeaderId { get; set; }
        public Nullable<int> NumberItems { get; set; }
        public Nullable<System.Guid> ArticlesId { get; set; }
        public Nullable<double> AmountArticles { get; set; }
        public Nullable<double> PriceUnit { get; set; }
        public Nullable<System.Guid> IvaId { get; set; }
        public Nullable<double> PriceTotal { get; set; }
        public Nullable<System.Guid> UserCreated { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.Guid> UserUpdate { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
    
        public virtual os_invoices_header os_invoices_header { get; set; }
    }
}