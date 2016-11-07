using System;
using System.Collections;

namespace Fayu.Iep.Core
{
    public abstract class DocumentSectionField : IDocumentSectionField
    {
        protected DocumentSectionField(string title)
        {
            Title = title;
        }
        public string Title { get; }
        public string Type => GetType().Name;
    }
}