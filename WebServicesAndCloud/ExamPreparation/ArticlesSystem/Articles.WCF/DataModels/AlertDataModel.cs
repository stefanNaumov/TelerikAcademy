using Articles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Articles.WCF.DataModels
{
    public class AlertDataModel
    {
        public static Expression<Func<Alert, AlertDataModel>> FromAlert
        {
            get
            {
                return a => new AlertDataModel
                {
                   Id = a.Id,
                   DateCreate = a.DateCreated,
                   Content = a.Content
                };
            }
        }

        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime DateCreate { get; set; }
    }
}