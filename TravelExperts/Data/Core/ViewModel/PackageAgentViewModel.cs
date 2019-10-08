using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Core.ViewModel
{
    public class PackageAgentViewModel
    {
        public List <Package> Packages { get; set; } 
        public List<Agent> Agents { get; set; }
        public List<Agency> Agencies { get; set; }

    }

    
}
