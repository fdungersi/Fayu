using System.Collections.Generic;

namespace Fayu.Iep.Core.Fields
{
    public sealed class SelectOptionField : DocumentSectionField
    {
        public SelectOptionField(string name, ICollection<string> options) : base(name)
        {
            Options = options;
        }

        public ICollection<string> Options { get; set; }
    }
}