namespace Fayu.Iep.Core.Fields
{
    public sealed class ConditionalField : DocumentSectionField
    {
        public ConditionalField(IDocumentSectionField field) : base(field.Title)
        {
        }


        public SelectOptionField True { get; set; }
    }
}