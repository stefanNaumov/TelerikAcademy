﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWorkTests
{
    public class Route
    {
        public string[] sofiaPlovdiv { get; protected set; }
        public string[] varnaBourgas { get; protected set; }
        public Route()
        {
            this.sofiaPlovdiv = new string[] { "Sofia", "Pazardzhik", "Plovdv" };
            this.varnaBourgas = new string[] { "Varna", "Nesebar", "Bourgas" };
        }
        public string[] GetRoute(Routes route)
        {
            if (route  == Routes.SofiaPlovdiv)
            {
                return this.sofiaPlovdiv;
            }
            else if (route == Routes.VarnaBourgas)
            {
                return this.varnaBourgas;
            }
            else
            {
                return null;
            }
        }
    }
}
