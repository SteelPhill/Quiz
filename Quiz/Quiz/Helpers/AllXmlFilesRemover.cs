using System.IO;

namespace Quiz.Helpers;

public static class AllXmlFilesRemover
{
    public static void Remove()
    {
        File.Delete(Constants.UsersXmlPath);
        File.Delete(Constants.BiologyXmlPath);
        File.Delete(Constants.GeographyXmlPath);
        File.Delete(Constants.HistoryXmlPath);
    }
}