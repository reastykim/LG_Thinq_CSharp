﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LGThingApi.Structures
{
    [Serializable]
    public class UserSaveInfo
    {
        public AuthorizationStructure TokensInfo { get; set; }
        public string UserName { get; set; }
    }
}
