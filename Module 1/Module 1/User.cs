//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Module_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> OfficeID { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual Office Office { get; set; }
        public virtual Role Role { get; set; }
    }
}
