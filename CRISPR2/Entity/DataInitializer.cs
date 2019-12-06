using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRISPR2.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            List<Organism> organismlist = new List<Organism>()
{
    new Organism() {OrganismName = "Bakteri" },
    new Organism() { OrganismName = "Maya" },
    new Organism() { OrganismName = "Bitki" },
    new Organism() { OrganismName = "Hayvan" },
    new Organism() { OrganismName = "İnsan" }
};


            List<ImplementType> types = new List<ImplementType>()
{
    new ImplementType() { ImplementName = "Gen Knock-Out" },
    new ImplementType() { ImplementName = "Crispr" },
    new ImplementType() { ImplementName = "Base Editing" },
    new ImplementType() { ImplementName = "Visualization" },

};
            List<Sgrna> sgrnalist = new List<Sgrna>()
{
    new Sgrna() {SgrnaName = "sgRNA 1" },
    new Sgrna() { SgrnaName = "sgRNA 2" },
 
};


            List<Offtarget> offtargetlist = new List<Offtarget>()
{
    new Offtarget() {OfftargetName = "NGS" },
    new Offtarget() { OfftargetName = "Sanger" },
    new Offtarget() { OfftargetName = "PCR" },

};

            foreach (var organisma in organismlist)
            {
                context.Organism.Add(organisma);
            }


            foreach (var type in types)
            {
                context.ImplementType.Add(type);
            }

            foreach (var sgrna in sgrnalist)
            {
                context.Sgrna.Add(sgrna);
            }

            foreach (var offtarget in offtargetlist)
            {
                context.OffTarget.Add(offtarget);
            }

            context.SaveChanges();


            base.Seed(context);
        }
    }
}