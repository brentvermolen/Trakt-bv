﻿using BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ArchiefRepository
    {
        private readonly TraktContext ctx = new TraktContext();

        public List<Archief> ReadArchieven()
        {
            return ctx.Archieven.ToList();
        }

        public List<Archief> ReadArchievenFromGebruiker(int gebruikerID)
        {
            List<Archief> archiefs = ReadArchieven();
            List<Archief> retArchiefs = new List<Archief>();

            foreach(Archief a in archiefs)
            {
                foreach(Gebruiker gebruiker in a.Gebruikers)
                {
                    if (gebruiker.ID == gebruikerID)
                    {
                        retArchiefs.Add(a);
                        break;
                    }
                }
            }

            return retArchiefs;
        }

        public void UpdateArchief(Archief archief)
        {
            ctx.Entry(archief).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public List<Aflevering> ReadAfleveringen(Func<Aflevering, bool> predicate)
        {
            return ctx.Afleveringen.Where(predicate).ToList();
        }

        public Archief ReadArchief(int iD)
        {
            return ctx.Archieven.Find(iD);
        }
    }
}
