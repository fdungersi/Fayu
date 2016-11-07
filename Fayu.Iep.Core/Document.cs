using System.Collections.Generic;

namespace Fayu.Iep.Core
{
    public class Document : IDocument
    {
        public Document()
        {
            State = DocumentState.Draft;
            Sections = new List<IDocumentSection>();
        }
        public string Name { get; set; }
        public ICollection<IDocumentSection> Sections { get; set; }
        public DocumentState State { get; set; }
    }
}