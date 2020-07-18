﻿using System;

namespace ContentTransformer.Common
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ServiceAttribute : Attribute
    {
        public Type ServiceType { get; set; }
    }
}
