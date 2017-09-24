﻿using MongoDB.Driver;
using OpenIddict.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenIddict.Mongo.Core
{
    public interface IMongoContext
    {
        IMongoDatabase Database { get; }
    }
}