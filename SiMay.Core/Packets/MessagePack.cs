﻿using SiMay.ReflectCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiMay.Core
{
    public class MessagePack : EntitySerializerBase
    {
        public byte MessageIcon { get; set; }

        public string MessageTitle { get; set; }

        public string MessageBody { get; set; }
    }
}
