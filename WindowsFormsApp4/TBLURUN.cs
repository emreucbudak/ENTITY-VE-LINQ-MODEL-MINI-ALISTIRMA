//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp4
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLURUN
    {
        public short URUNID { get; set; }
        public string URUNAD { get; set; }
        public Nullable<int> URUNKATEGORİ { get; set; }
        public Nullable<int> URUNMARKA { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public Nullable<int> FIYAT { get; set; }
    
        public virtual MARKA MARKA { get; set; }
        public virtual TBLKATEGORI TBLKATEGORI { get; set; }
    }
}
