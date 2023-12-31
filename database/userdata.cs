//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.RegularExpressions;
using System.Linq;
namespace c_project.database
{
    using System;
    using System.Collections.Generic;
    using System.Net.Mail;
    
    public partial class userdata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public userdata()
        {
            this.projects = new HashSet<project>();
            this.tasks = new HashSet<task>();
        }
    
        public int u_id { get; set; }
        public string u_name { get; set; }
        public string u_email { get; set; }
        public string u_password { get; set; }
        public string img { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project> projects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<task> tasks { get; set; }

        public void validname(string name, ref bool isvalidn)
        {
            //isvalid = false;
            String regex = @"^[a-z' 'A-Z]+$";
            Regex rgex = new Regex(regex);
            if (rgex.IsMatch(name))
            {
                isvalidn = true;
            }
            else
                isvalidn = false;
        }
        public void validemail(string email, ref bool isvalide)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                isvalide = true;
            }
            catch
            {
                isvalide = false;
            }
        }
        public void vaildpass(string pass, ref bool isvaildp)
        {
            if (pass.Length > 8)
                isvaildp = true;
            else
                isvaildp = false;

        }
        public void adduser(ref bool isvaildn, ref bool isvailde, ref bool isvaildpass, ref bool isvaid)
        {
            if (isvailde && isvaildn && isvaildpass)
                isvaid = true;
            else
                isvaid = false;
        }
        public bool isfoundUser(userdata user)
        {
            //a method to search for a user in the userdata database
            Database db = new Database();
            var users = db.userdatas.Where(a => a.u_email == user.u_email && a.u_password == user.u_password).FirstOrDefault();
            if (users != null && users.u_email == user.u_email && users.u_password == user.u_password)
            {
                return true;
            }
            return false;
        }
    }
}
