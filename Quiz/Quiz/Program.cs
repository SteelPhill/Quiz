using Quiz.Database;
using Quiz.Databases;
using Quiz.Entities;
using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;
using System.Collections.Generic;

namespace Quiz;

public class Program
{
    public static void Main()
    {
        /*Использовать для пересоздания изначальных xml-файлов*/
        //RecreateAllXmlFiles();

        //IUserDB userDB = new UserDB(Utile.SerializeHelper
        //    .Deserialize<List<User>>(Constants.UsersXmlPath));

        //IQuestionDB biologyQuestionDB = new QuestionDB(Utile.SerializeHelper
        //    .Deserialize<List<Question>>(Constants.BiologyXmlPath));

        //IQuestionDB geographyQuestionDB = new QuestionDB(Utile.SerializeHelper
        //    .Deserialize<List<Question>>(Constants.GeographyXmlPath));

        //IQuestionDB historyQuestionDB = new QuestionDB(Utile.SerializeHelper
        //    .Deserialize<List<Question>>(Constants.HistoryXmlPath));



        //Utile.SerializeHelper.Serialize(userDB.Users, Constants.UsersXmlPath);
        //Utile.SerializeHelper.Serialize(biologyQuestionDB.Questions, Constants.BiologyXmlPath);
        //Utile.SerializeHelper.Serialize(geographyQuestionDB.Questions, Constants.GeographyXmlPath);
        //Utile.SerializeHelper.Serialize(historyQuestionDB.Questions, Constants.HistoryXmlPath);

        Console.ReadKey();
    }

    private static void RecreateAllXmlFiles()
    {
        AllXmlFilesRemover.Remove();
        OriginalXmlFilesCreator.Create();
    }
}