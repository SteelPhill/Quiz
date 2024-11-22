using Quiz.Commands;
using Quiz.Commands.AddQuestionMenuCommands;
using Quiz.Commands.AuthorizationCommands;
using Quiz.Commands.MainMenuCommands;
using Quiz.Commands.NewQuizMenuCommands;
using Quiz.Commands.RemoveQuestionMenuCommands;
using Quiz.Commands.SettingsCommands;
using Quiz.Commands.ShowQuestionsMenuCommands;
using Quiz.Commands.ShowRatingMenuCommands;
using Quiz.Databases;
using Quiz.Entities;
using Quiz.Enums;
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

        try
        {
            StartQuiz();
        }
        catch (Exception)
        {
            Console.WriteLine("Не удалось запустить программу!");
            Console.WriteLine();
            Console.WriteLine("Возможная причина: не существует файла(ов) с вопросами и/или файла с пользователями.");
            Console.WriteLine();
            Console.WriteLine("Восстановлены исходные файлы.");
            RecreateAllXmlFiles();
            ConsoleWaiting.WaitAnyKey();
        }
    }

    private static void StartQuiz()
    {
        IUserDB userDB = new UserDB(Utile.SerializeHelper.Deserialize<List<User>>(Constants.UsersXmlPath));

        IQuestionDB biologyQuestionDB = 
            new QuestionDB(Utile.SerializeHelper.Deserialize<List<Question>>(Constants.BiologyXmlPath));
        IQuestionDB geographyQuestionDB = 
            new QuestionDB(Utile.SerializeHelper.Deserialize<List<Question>>(Constants.GeographyXmlPath));
        IQuestionDB historyQuestionDB = 
            new QuestionDB(Utile.SerializeHelper.Deserialize<List<Question>>(Constants.HistoryXmlPath));

        IMenu authorizationMenu = CreateMenu(userDB, biologyQuestionDB, geographyQuestionDB, historyQuestionDB);

        authorizationMenu.Start();

        Utile.SerializeHelper.Serialize(userDB.Users, Constants.UsersXmlPath);
        Utile.SerializeHelper.Serialize(biologyQuestionDB.Questions, Constants.BiologyXmlPath);
        Utile.SerializeHelper.Serialize(geographyQuestionDB.Questions, Constants.GeographyXmlPath);
        Utile.SerializeHelper.Serialize(historyQuestionDB.Questions, Constants.HistoryXmlPath);
    }

    private static IMenu CreateMenu(
        IUserDB userDB,
        IQuestionDB biologyQuestionDB,
        IQuestionDB geographyQuestionDB,
        IQuestionDB historyQuestionDB)
    {
        IMenu newQuizSubmenu = new ConsoleMenu("Выберите тему:");
        newQuizSubmenu.AddCommand(new NewBiologyQuizCommand("Биология", biologyQuestionDB));
        newQuizSubmenu.AddCommand(new NewGeographyQuizCommand("География", geographyQuestionDB));
        newQuizSubmenu.AddCommand(new NewHistoryQuizCommand("История", historyQuestionDB));
        newQuizSubmenu.AddCommand(new NewMixedQuizCommand("Смешанная", biologyQuestionDB,
            geographyQuestionDB, historyQuestionDB));

        IMenu showRatingSubmenu = new ConsoleMenu("Выберите тему:");
        showRatingSubmenu.AddCommand(new ShowBiologyRatingCommand("Биология", Topic.Biology, userDB));
        showRatingSubmenu.AddCommand(new ShowGeographyRatingCommand("География", Topic.Geography, userDB));
        showRatingSubmenu.AddCommand(new ShowHistoryRatingCommand("История", Topic.History, userDB));
        showRatingSubmenu.AddCommand(new ShowMixedRatingCommand("Смешанная викторина", Topic.Mixed, userDB));

        IMenu settingsSubmenu = new ConsoleMenu("Настройки");
        settingsSubmenu.AddCommand(new ChangeBirthDateCommand("Изменить дату рождения"));
        settingsSubmenu.AddCommand(new ChangePasswordCommand("Изменить пароль"));

        IMenu showQuestionsSubmenu = new ConsoleMenu("Выберите тему:");
        showQuestionsSubmenu.AddCommand(new ShowBiologyQuestionsCommand("Биология", biologyQuestionDB));
        showQuestionsSubmenu.AddCommand(new ShowGeographyQuestionsCommand("География", geographyQuestionDB));
        showQuestionsSubmenu.AddCommand(new ShowHistoryQuestionsCommand("История", historyQuestionDB));

        IMenu addQuestionSubmenu = new ConsoleMenu("Выберите тему:");
        addQuestionSubmenu.AddCommand(new AddBiologyQuestionCommand("Биология", Topic.Biology, biologyQuestionDB));
        addQuestionSubmenu.AddCommand(new AddGeographyQuestionCommand("География", Topic.Geography, geographyQuestionDB));
        addQuestionSubmenu.AddCommand(new AddHistoryQuestionCommand("История", Topic.History, historyQuestionDB));

        IMenu removeQuestionSubmenu = new ConsoleMenu("Выберите тему:");
        removeQuestionSubmenu.AddCommand(new RemoveBiologyQuestionCommand("Биология", Topic.Biology, biologyQuestionDB));
        removeQuestionSubmenu.AddCommand(new RemoveGeographyQuestionCommand("География", Topic.Geography, geographyQuestionDB));
        removeQuestionSubmenu.AddCommand(new RemoveHistoryQuestionCommand("История", Topic.History, historyQuestionDB));

        IMenu mainMenu = new ConsoleMenu("Главное меню");
        mainMenu.AddCommand(new SubmenuExecuterCommand("Новая викторина", newQuizSubmenu));
        mainMenu.AddCommand(new ShowResultsCommand("Результаты"));
        mainMenu.AddCommand(new SubmenuExecuterCommand("Рейтинг", showRatingSubmenu));
        mainMenu.AddCommand(new SubmenuExecuterCommand("Настройки", settingsSubmenu));
        mainMenu.AddCommand(new ShowUsersCommand("Список пользователей", userDB));
        mainMenu.AddCommand(new RemoveUserCommand("Удалить пользователя", userDB));
        mainMenu.AddCommand(new SubmenuExecuterCommand("Список вопросов", showQuestionsSubmenu));
        mainMenu.AddCommand(new SubmenuExecuterCommand("Добавить вопрос", addQuestionSubmenu));
        mainMenu.AddCommand(new SubmenuExecuterCommand("Удалить вопрос", removeQuestionSubmenu));

        IMenu authorizationMenu = new ConsoleMenu("Меню авторизации", true);
        authorizationMenu.AddCommand(new LoginCommand("Вход", mainMenu, userDB));
        authorizationMenu.AddCommand(new RegistrationCommand("Регистрация", mainMenu, userDB));

        return authorizationMenu;
    }

    private static void RecreateAllXmlFiles()
    {
        AllXmlFilesRemover.Remove();
        OriginalXmlFilesCreator.Create();
    }
}