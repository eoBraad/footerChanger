using Spire.Doc;

namespace FooterChanger.Helpers;

public static class DocEditorHelper
{
    public static void ChangeFooter(string selectedFilePath, string delimiter, string ficValue, string password)
    {
        var document = new Document();
        document.LoadFromFile(selectedFilePath, FileFormat.Auto, password);
        
        document.Replace(delimiter, ficValue, true, true);
        document.SaveToFile(selectedFilePath);
    }
}