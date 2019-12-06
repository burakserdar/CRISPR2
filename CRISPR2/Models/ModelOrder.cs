using CRISPR2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRISPR2.Models
{
    public class ModelOrder
    {
        public IEnumerable<Organism> OrganismList { get; set; }
        public IEnumerable<ImplementType> ImplementList { get; set; }

        public IEnumerable<Sgrna> SgrnaList { get; set; }

        public IEnumerable<Offtarget> OfftargetList { get; set; }

    }
}