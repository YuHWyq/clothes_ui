﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClothingDBEntities2 : DbContext
    {
        public ClothingDBEntities2()
            : base("name=ClothingDBEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<buy_materials_details> buy_materials_details { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<get_materials> get_materials { get; set; }
        public virtual DbSet<in_materialr> in_materialr { get; set; }
        public virtual DbSet<in_money> in_money { get; set; }
        public virtual DbSet<in_repertory> in_repertory { get; set; }
        public virtual DbSet<materialr> materialr { get; set; }
        public virtual DbSet<materialr_details> materialr_details { get; set; }
        public virtual DbSet<materialr_epertory> materialr_epertory { get; set; }
        public virtual DbSet<materialr_in> materialr_in { get; set; }
        public virtual DbSet<materials_plan> materials_plan { get; set; }
        public virtual DbSet<materials_plan_details> materials_plan_details { get; set; }
        public virtual DbSet<materials_quality_testing> materials_quality_testing { get; set; }
        public virtual DbSet<order_details> order_details { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<out_materialr> out_materialr { get; set; }
        public virtual DbSet<out_money> out_money { get; set; }
        public virtual DbSet<out_repertory> out_repertory { get; set; }
        public virtual DbSet<pro_production> pro_production { get; set; }
        public virtual DbSet<pro_repertory> pro_repertory { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<product_plan> product_plan { get; set; }
        public virtual DbSet<product_plan_details> product_plan_details { get; set; }
        public virtual DbSet<product_quality_testing> product_quality_testing { get; set; }
        public virtual DbSet<product_type> product_type { get; set; }
    }
}
