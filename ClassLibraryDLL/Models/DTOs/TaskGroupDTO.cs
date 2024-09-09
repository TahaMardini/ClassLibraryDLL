﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDLL.Models.DTOs
{
    public class TaskGroupDTO
    {
        public int Id { get; set; }
        public required string GroupName { get; set; }
        public required int TaskListTemplateID { get; set; }
        public int GroupOrder { get; set; }
    }
}
