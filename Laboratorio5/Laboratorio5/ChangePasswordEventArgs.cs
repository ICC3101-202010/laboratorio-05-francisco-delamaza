﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    class ChangePasswordEventArgs: EventArgs
    {
        public string Email { get; set; }
        public string Number { get; set; }
        public string Username { get; set; }
    }
}
