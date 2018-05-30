﻿using BL.Domain;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CollectieManager
    {
        private readonly CollectieRepository repo = new CollectieRepository();

        public List<Collectie> ReadCollecties()
        {
            return repo.GetCollecties().ToList();
        }

        public object ReadCollectie(int id)
        {
            return repo.GetCollectie(id);
        }
    }
}
