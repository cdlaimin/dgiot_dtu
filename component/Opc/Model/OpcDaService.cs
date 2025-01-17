﻿// <copyright file="OpcDaService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using TitaniumAS.Opc.Client.Da;

namespace Da
{
    public class OpcDaService
    {
        public string Host { get; set; }

        public string ServiceId { get; set; }

        public OpcDaServer Service { get; set; }

        public Dictionary<String, OpcDaGroup> OpcDaGroupS;
    }
}
