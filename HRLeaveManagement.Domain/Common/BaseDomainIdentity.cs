 using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Domain.Common
{
    public abstract class BaseDomainIdentity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public String CreatedBy  { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
