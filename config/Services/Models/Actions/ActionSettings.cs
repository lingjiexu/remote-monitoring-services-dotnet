﻿// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;

namespace Microsoft.Azure.IoTSolutions.UIConfig.Services.Models.Actions
{
    public interface IActionSettings
    {
        ActionType Type { get; }

        IDictionary<string, object> Settings { get; set; }
    }
}
