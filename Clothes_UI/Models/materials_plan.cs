//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clothes_UI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class materials_plan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public materials_plan()
        {
            this.in_materialr = new HashSet<in_materialr>();
        }
    
        public int materialr_plan_id { get; set; }
        public string status { get; set; }
        public string operator_per { get; set; }
        public string person_handling { get; set; }
        public System.DateTime materials_plan_time { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<in_materialr> in_materialr { get; set; }
    }
}
