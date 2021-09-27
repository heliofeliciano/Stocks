using Stocks.Domain.Enums;
using Stocks.Shared.ValueObjects;

namespace Stocks.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number)
        {
            Number = number;
        }

        public Document(string number, EDocumentType documentType)
        {
            Number = number;
            DocumentType = documentType;
        }

        public string Number { get; private set; }
        public EDocumentType DocumentType { get; private set; }
    }
}
