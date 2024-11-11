using Quiz.Entities;

namespace Quiz.Menus.ConsoleQuestionMenu;

interface IQuestionWriter
{
    void Write(ref int selector, Question question, int questionNumber);
}