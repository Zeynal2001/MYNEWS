﻿using Microsoft.AspNetCore.Identity;
using System.Data;
using System.Xml.Linq;

namespace MYNEWS.Entities
{
    public class AppUser : IdentityUser
    {
        public string UserFName { get; set; }
        public string UserLName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? ProfilePhotoPath { get; set; }

        //TODO: public bool IsDeleted { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
