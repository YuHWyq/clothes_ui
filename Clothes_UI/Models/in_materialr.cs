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
    
    public partial class in_materialr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public in_materialr()
        {
            this.buy_materials_details = new HashSet<buy_materials_details>();
            this.materials_quality_testing = new HashSet<materials_quality_testing>();
            this.out_money = new HashSet<out_money>();
        }
    
        public string in_materialr_id { get; set; }
        public int materialr_plan_id { get; set; }
        public string person_handling { get; set; }
        public string status { get; set; }
        public string operator_per { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<buy_materials_details> buy_materials_details { get; set; }
        public virtual materials_plan materials_plan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<materials_quality_testing> materials_quality_testing { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<out_money> out_money { get; set; }
    }
}
