using Quiz.Entities;

namespace Quiz.Menus.ConsoleQuestionMenu;

interface IQuestionSelector
{
    void Select(ref int selector, Question question, int questionNumber);
}