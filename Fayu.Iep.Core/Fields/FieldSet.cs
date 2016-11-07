using System.Collections.Generic;

namespace Fayu.Iep.Core.Fields
{
    public sealed class FieldSet : DocumentSectionField
    {
        public FieldSet(string name, ICollection<DocumentSectionField> fields ) : base(name)
        {
            Fields = fields;
        }

        public ICollection<DocumentSectionField> Fields { get; }
    }
}