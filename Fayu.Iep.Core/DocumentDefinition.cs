using System.Collections.Generic;

namespace Fayu.Iep.Core
{
    public class DocumentDefinition : IDocumentDefinition
    {
        public DocumentDefinition()
        {
            Sections = new List<IDocumentSection>();
        }
        public string Name { get; set; }
        public ICollection<IDocumentSection> Sections { get; set; }
    }
}