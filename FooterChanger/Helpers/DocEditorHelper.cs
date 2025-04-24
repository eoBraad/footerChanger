using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Pages;
using BorderStyle = Spire.Doc.Documents.BorderStyle;


namespace FooterChanger.Helpers;

public static class DocEditorHelper
{
    public static void ChangeFooter(string selectedFilePath, string ficValue, List<string> passwords, bool save,
        bool print, string printerName, int inicio, int fim, Action showPassword)
    {
        var document = new Document();
        var correctPassword = "";
        var fileOpened = false;

        foreach (var password in passwords)
        {
            try
            {
                document.LoadFromFile(selectedFilePath, FileFormat.Auto, password);
                correctPassword = password;
                fileOpened = true;
                break;
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        if (!fileOpened)
        {
            showPassword();
            throw new Exception("Nenhuma das senhas funcionaram, insira uma nova senha");
        }

        foreach (Section section in document.Sections)
        {
            section.HeadersFooters.Footer.Paragraphs.Clear();
            section.HeadersFooters.Footer.ChildObjects.Clear();

            var footer = section.HeadersFooters.Footer;
            var footerParagraph = footer.AddParagraph();

            footerParagraph.Format.Borders.Top.BorderType = BorderStyle.Single;
            footerParagraph.Format.Borders.Top.LineWidth = 2.0f;

            footerParagraph.Format.Borders.Top.Color = Color.Black;
            var leftText = footerParagraph.AppendText($"F.I.C. {ficValue}");
            leftText.CharacterFormat.TextColor = Color.Purple;
            leftText.CharacterFormat.Bold = true;

            footerParagraph.AppendText("\t");

            var rightText = footerParagraph.AppendText($"| PÁGINA ");
            rightText.CharacterFormat.TextColor = Color.Purple;
            rightText.CharacterFormat.Bold = true;

            // Campo dinâmico de número da página
            var pageField = footerParagraph.AppendField("Page", FieldType.FieldPage);
            pageField.CharacterFormat.TextColor = Color.Purple;
            pageField.CharacterFormat.Bold = true;
        }

        if (save)
        {
            document.SaveToFile(selectedFilePath, FileFormat.Auto);
        }

        if (print)
            PrintDocument(selectedFilePath, printerName, correctPassword);
    }

    public static void PrintDocument(string selectedFilePath, string printerName, string password)
    {
        var document = new Document();
        document.LoadFromFile(selectedFilePath, FileFormat.Auto, password);

        document.PrintDocument.PrinterSettings.PrinterName = printerName;
        // document.PrintDocument.PrinterSettings.
        document.PrintDocument.Print();
    }
}