using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fayu.Iep.Core
{
    public interface IDocumentDefinition
    {
        string Name { get; set; }
        ICollection<IDocumentSection> Sections { get; set; }
    }
}
