using System.Collections;
using System.Collections.Generic;

namespace Fayu.Iep.Core
{
    public interface IDocumentSection
    {
        string Name { get; }
        string Title { get; set; }
        ICollection<IDocumentSectionField> Fields { get; set; }
        ICollection<IDocumentSection> Sections { get; set; }
    }
}