﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Application.Dtos.Hateoas
{
    public class HateoasLink
    {
        public List<HateoasData> Links { get; set; } = new List<HateoasData>();
    }
}
