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
    
    public partial class in_repertory
    {
        public int in_repertory_id { get; set; }
        public int pro_production_id { get; set; }
        public string person_handling { get; set; }
        public string operator_per { get; set; }
        public string in_time { get; set; }
    
        public virtual pro_production pro_production { get; set; }
    }
}
