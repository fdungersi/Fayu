using System.Collections.Generic;

namespace Fayu.Iep.Core.Fields
{
    public sealed class TableField : DocumentSectionField
    {
        public TableField(string name) : base(name)
        {
            Fields = new List<IDocumentSectionField>();
        }

        public List<IDocumentSectionField> Fields { get; }
    }
}