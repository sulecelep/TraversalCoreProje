using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            
            document.Open();    

            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");

            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/dosya1.pdf","application/pdf","dosya1.pdf");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            string Arial_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");
            BaseFont bf = BaseFont.CreateFont(Arial_TFF, BaseFont.IDENTITY_H, true);
            Font f = new Font(bf, 12, Font.NORMAL);
            Paragraph paragraph = new Paragraph("Traversal - Statik Müşteri Raporu\n\n", f);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();


            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell(new Phrase("Müşteri Adı", f));
            pdfPTable.AddCell(new Phrase("Müşteri Soyadı", f));
            pdfPTable.AddCell(new Phrase("Müşteri TC Kimlik", f));

            pdfPTable.AddCell(new Phrase("Kemal", f));
            pdfPTable.AddCell(new Phrase("Yıldırım", f));
            pdfPTable.AddCell(new Phrase("1234567890", f));

            pdfPTable.AddCell(new Phrase("Eylül", f));
            pdfPTable.AddCell(new Phrase("Sarıgazi", f));
            pdfPTable.AddCell(new Phrase("1234567891", f));

            pdfPTable.AddCell(new Phrase("Zeynep", f));
            pdfPTable.AddCell(new Phrase("Akdağ", f));
            pdfPTable.AddCell(new Phrase("1234567892", f));


            document.Add(pdfPTable);

            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}
