using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRISPR2.Entity
{
    public class Order
    {
        public int Id { get; set; }


        public int OrganismId { get; set; }
        public virtual Organism Organism { get; set; }
        public string OrganismNameName { get; set; }


        public int ImplementTypeId { get; set; }
        public virtual ImplementType Implement { get; set; }
        public string ImplementNameName { get; set; }



        public int SgrnaId { get; set; }
        public virtual Sgrna Sgrna { get; set; }
        public string SgrnaNameName { get; set; }


        public int OfftargetId { get; set; }
        public virtual Offtarget Offtarget { get; set; }
        public string OfftargetNameName { get; set; }




    }
}