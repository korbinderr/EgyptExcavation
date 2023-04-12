using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex00.Models.MummyViewModels
{
    public class PageInfo
    {
        public int TotalNumMummies { get; set; }
        public int MummiesPerPage { get; set; }
        public int CurrentPage { get; set; }

        //Figure out how many pages we need.
        public int TotalPages => (int)Math.Ceiling((double)TotalNumMummies / MummiesPerPage);
    }
}