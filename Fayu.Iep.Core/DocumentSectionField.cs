using System;
using System.Collections;
using System.Collections.Generic;

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

    public sealed class TextField : DocumentSectionField
    {
        public TextField(string name) : base(name)
        {
        }
    }

    public sealed class FieldSet : DocumentSectionField
    {
        public FieldSet(string name, ICollection<DocumentSectionField> fields ) : base(name)
        {
            Fields = fields;
        }

        public ICollection<DocumentSectionField> Fields { get; }
    }

    public sealed class SelectOptionField : DocumentSectionField
    {
        public SelectOptionField(string name, ICollection<string> options) : base(name)
        {
            Options = options;
        }

        public ICollection<string> Options { get; set; }
    }

    public sealed class ConditionalField : DocumentSectionField
    {
        public ConditionalField(IDocumentSectionField field) : base(field.Title)
        {
        }


        public SelectOptionField True { get; set; }
    }

    public sealed class TableField : DocumentSectionField
    {
        public TableField(string name) : base(name)
        {
            Fields = new List<IDocumentSectionField>();
        }

        public List<IDocumentSectionField> Fields { get; }
    }

  

}