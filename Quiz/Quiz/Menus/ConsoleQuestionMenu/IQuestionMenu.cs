using Quiz.Entities;

namespace Quiz.Menus.ConsoleQuestionMenu;

interface IQuestionMenu
{
    bool IsCorrect(Question question, int questionNumber);
}