using Intex00.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex00.Models.MummyViewModels
{
    public class MummyViewModel
    {
        public IQueryable<Burialall7> burials { get; set; }
        public IQueryable<Burialmain> burialmains { get; set; }
        public IQueryable<Textile> textiles { get; set; }
        public IQueryable<BurialmainTextile> bmtextile { get; set; }

        public PageInfo PageInfo { get; set; }

        public string ReturnUrl { get; set; }
    }
}