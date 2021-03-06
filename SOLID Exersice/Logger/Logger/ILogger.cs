﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Logger
{
    public interface ILogger
    {
        void Info(string date, string message);
        void Error(string date, string message);
    }
}
