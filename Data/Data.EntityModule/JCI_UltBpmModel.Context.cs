﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Data.EntityModule
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Johnson_UltBpmEntities : DbContext
    {
        public Johnson_UltBpmEntities()
            : base("name=Johnson_UltBpmEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_AssignedToUserFuture> T_AssignedToUserFuture { get; set; }
        public virtual DbSet<T_Dic_Parameter> T_Dic_Parameter { get; set; }
        public virtual DbSet<T_GZOrderProcessConfig> T_GZOrderProcessConfig { get; set; }
        public virtual DbSet<T_GZOrderRelease> T_GZOrderRelease { get; set; }
        public virtual DbSet<T_GZOrderReleaseAttachment> T_GZOrderReleaseAttachment { get; set; }
        public virtual DbSet<T_GZOrderReleaseProduct> T_GZOrderReleaseProduct { get; set; }
        public virtual DbSet<T_GZOrderReview> T_GZOrderReview { get; set; }
        public virtual DbSet<T_GZOrderReviewProduct> T_GZOrderReviewProduct { get; set; }
        public virtual DbSet<T_LogAssignedToUser> T_LogAssignedToUser { get; set; }
        public virtual DbSet<T_LogMail> T_LogMail { get; set; }
        public virtual DbSet<T_MailBodyTemplate> T_MailBodyTemplate { get; set; }
        public virtual DbSet<T_MailProcessConfig> T_MailProcessConfig { get; set; }
        public virtual DbSet<T_MailTasks> T_MailTasks { get; set; }
        public virtual DbSet<T_SQInfo> T_SQInfo { get; set; }
        public virtual DbSet<T_SQPrice> T_SQPrice { get; set; }
        public virtual DbSet<T_TimeJY> T_TimeJY { get; set; }
        public virtual DbSet<T_TimeJYCho> T_TimeJYCho { get; set; }
        public virtual DbSet<T_TimeJYLS> T_TimeJYLS { get; set; }
        public virtual DbSet<T_Attachment> T_Attachment { get; set; }
        public virtual DbSet<T_Countersign> T_Countersign { get; set; }
        public virtual DbSet<T_Process> T_Process { get; set; }
        public virtual DbSet<T_ProcessCategory> T_ProcessCategory { get; set; }
        public virtual DbSet<T_ProcessDbTables> T_ProcessDbTables { get; set; }
        public virtual DbSet<T_ProcessFavorites> T_ProcessFavorites { get; set; }
        public virtual DbSet<T_StepUsers> T_StepUsers { get; set; }
        public virtual DbSet<T_TaskApproval> T_TaskApproval { get; set; }
        public virtual DbSet<T_Travel> T_Travel { get; set; }
        public virtual DbSet<T_UltimusVariables> T_UltimusVariables { get; set; }
    }
}
