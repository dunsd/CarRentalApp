//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HardwareRentalApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypesOfHardware
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypesOfHardware()
        {
            this.HardwareRentalRecords = new HashSet<HardwareRentalRecord>();
        }
    
        public int id { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<int> Value { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HardwareRentalRecord> HardwareRentalRecords { get; set; }
    }
}
