﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCreater.models
{
    internal class Settings
    {
        public List<bool>? Toggles { get; set; }
        public string? DisciplineText { get; set; }
        public string? EducateInstitution { get; set; }
    }
}
