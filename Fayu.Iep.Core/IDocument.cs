using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fayu.Iep.Core
{
    public interface IDocument
    {
        string Name { get; set; }
        ICollection<IDocumentSection> Sections { get; set; }
        DocumentState State { get; set; }
    }
}
