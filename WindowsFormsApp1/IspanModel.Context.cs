﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class iSpanProjectEntities : DbContext
    {
        public iSpanProjectEntities()
            : base("name=iSpanProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AD> AD { get; set; }
        public virtual DbSet<ArguePic> ArguePic { get; set; }
        public virtual DbSet<Argument> Argument { get; set; }
        public virtual DbSet<ArgumentType> ArgumentType { get; set; }
        public virtual DbSet<BigType> BigType { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<CommentPic> CommentPic { get; set; }
        public virtual DbSet<CountryList> CountryList { get; set; }
        public virtual DbSet<Coupons> Coupons { get; set; }
        public virtual DbSet<FAQ> FAQ { get; set; }
        public virtual DbSet<FAQType> FAQType { get; set; }
        public virtual DbSet<Follows> Follows { get; set; }
        public virtual DbSet<Likes> Likes { get; set; }
        public virtual DbSet<MemberAccount> MemberAccount { get; set; }
        public virtual DbSet<OfficialCoupons> OfficialCoupons { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderStatuses> OrderStatuses { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductDetail> ProductDetail { get; set; }
        public virtual DbSet<ProductPic> ProductPic { get; set; }
        public virtual DbSet<RegionList> RegionList { get; set; }
        public virtual DbSet<Shipper> Shipper { get; set; }
        public virtual DbSet<ShippingStatuses> ShippingStatuses { get; set; }
        public virtual DbSet<SmallType> SmallType { get; set; }
    }
}
