﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampManager.Shared;
public class CampModel
{
    [BsonId]
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public int Year { get; set; }

}
