using System;
using System.Collections.Generic;

#nullable disable

namespace LoginProject.DatabaseModel
{
    public partial class UserLoginMaster
    {
        public int Id { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
    }
}
