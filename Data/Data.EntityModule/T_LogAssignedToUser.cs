//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class T_LogAssignedToUser
    {
        public string Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateUserCode { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public string ModifyUserCode { get; set; }
        public int DelStatus { get; set; }
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public string StepLabel { get; set; }
        public string TaskId { get; set; }
        public string OriginalAssignedToUser { get; set; }
        public string TargetAssignedToUser { get; set; }
        public string AssignedType { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string Notes { get; set; }
    }
}
