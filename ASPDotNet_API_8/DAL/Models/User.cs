﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SocialMediaApi.DAL;
public class User:IdentityUser
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

  

}
