﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Yunpian.Sdk.ApiScopes
{
    public interface IApiScope
    {
        ApiScopeOptions Options { get; }
    }
}
