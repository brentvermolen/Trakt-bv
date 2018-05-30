﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Domain;

namespace DAL
{
    public class SerieRepository
    {
        private readonly TraktContext ctx = new TraktContext();

        public List<Aflevering> ReadAfleveringen(Func<Aflevering, bool> predicate)
        {
            return ctx.Afleveringen.Where(predicate).ToList();
        }
    }
}