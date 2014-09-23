﻿using Articles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Articles.WebAPI.Models
{
    public class TagDataModel
    {
        public static Expression<Func<Tag, TagDataModel>> FromTag
        {
            get
            {
                return m => new TagDataModel
                {
                    Id = m.Id,
                    Name = m.Name
                };
            }
        }
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
