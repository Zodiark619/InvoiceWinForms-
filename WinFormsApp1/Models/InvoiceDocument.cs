using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class InvoiceDocument:IDocument
    {
        private readonly IEnumerable<InvoiceDto> _lines;

        public InvoiceDocument(IEnumerable<InvoiceDto> lines)
        {
            _lines = lines;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(20);
                page.DefaultTextStyle(x => x.FontSize(11));

                page.Content().Column(column =>
                {
                    column.Spacing(10);

                    column.Item().Text("INVOICE")
                        .FontSize(20)
                        .Bold()
                        .AlignCenter();

                    column.Item().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(4); // Product
                            columns.RelativeColumn(1); // Qty
                            columns.RelativeColumn(2); // Price
                            columns.RelativeColumn(2); // Total
                        });

                        // Header
                        table.Header(header =>
                        {
                            header.Cell().Text("Product").Bold();
                            header.Cell().Text("Qty").Bold();
                            header.Cell().Text("Price").Bold();
                            header.Cell().Text("Total").Bold();
                        });

                        // Rows
                        foreach (var line in _lines)
                        {
                            table.Cell().Text(line.ProductName);
                            table.Cell().Text(line.Quantity.ToString());
                            table.Cell().Text(line.UnitPrice.ToString("C"));
                            table.Cell().Text(line.Total.ToString("C"));
                        }
                    });

                    column.Item().AlignRight().Text(text =>
                    {
                        text.Span("Grand Total: ").Bold();
                        text.Span(_lines.Sum(x => x.Total).ToString("C"));
                    });
                });
            });
        }
    }
}
