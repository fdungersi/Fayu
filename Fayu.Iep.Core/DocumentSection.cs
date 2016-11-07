using System.Collections.Generic;

namespace Fayu.Iep.Core
{
    public class DocumentSection : IDocumentSection
    {
        public DocumentSection(string name)
        {
            Name = name;
        }
        public string Name { get;  }
        public string Title { get; set; }
        public ICollection<IDocumentSectionField> Fields { get; set; }
        public ICollection<IDocumentSection> Sections { get; set; }
    }
}