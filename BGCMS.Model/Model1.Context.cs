﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BGMES.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BGMESEntities : DbContext
    {
        public BGMESEntities()
            : base("name=BGMESEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TTS0091> TTS0091 { get; set; }
        public virtual DbSet<TTS0092> TTS0092 { get; set; }
        public virtual DbSet<TEPEP03> TEPEP03 { get; set; }
        public virtual DbSet<TESUSERINFO> TESUSERINFOes { get; set; }
    }
}
