﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserDetailDto:IDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
