﻿namespace TraversalCoreProje.Areas.Admin.Models
{
    public class RoleAssignViewModel
    {
        public int RoleId { get; set; } 
        public string RoleName { get; set; }
        public bool RoleExist { get; set; }
        //kullanıcıda rol olup olmadığına bakar RoleExist
    }
}
