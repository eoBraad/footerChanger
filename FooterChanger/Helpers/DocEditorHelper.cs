using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Pages;
using BorderStyle = Spire.Doc.Documents.BorderStyle;


namespace FooterChanger.Helpers;

public static class DocEditorHelper
{
    /// <summary>
    /// Altera o rodapé de um documento Word, adicionando informações como FIC e número de página.
    /// </summary>
    /// <param name="selectedFilePath">Caminho do arquivo selecionado.</param>
    /// <param name="ficValue">Valor do FIC a ser adicionado no rodapé.</param>
    /// <param name="passwords">Lista de senhas para abrir o documento.</param>
    /// <param name="save">Indica se o documento deve ser salvo após a alteração.</param>
    /// <param name="print">Indica se o documento deve ser impresso após a alteração.</param>
    /// <param name="printerName">Nome da impressora para impressão.</param>
    /// <param name="inicio">Número da página inicial.</param>
    /// <param name="fim">Número da página final.</param>
    /// <param name="showPassword">Ação para exibir o campo de senha na interface.</param>
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

    /// <summary>
    /// Imprime o documento Word utilizando a impressora especificada.
    /// </summary>
    /// <param name="selectedFilePath">Caminho do arquivo selecionado.</param>
    /// <param name="printerName">Nome da impressora para impressão.</param>
    /// <param name="password">Senha para abrir o documento.</param>
    public static void PrintDocument(string selectedFilePath, string printerName, string password)
    {
        var document = new Document();
        document.LoadFromFile(selectedFilePath, FileFormat.Auto, password);

        document.PrintDocument.PrinterSettings.PrinterName = printerName;
        // document.PrintDocument.PrinterSettings.
        document.PrintDocument.Print();
    }
}
