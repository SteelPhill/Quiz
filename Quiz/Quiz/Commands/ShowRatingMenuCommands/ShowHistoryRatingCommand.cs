using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.ShowRatingMenuCommands;

public class ShowHistoryRatingCommand : ShowRatingCommand
{
    public ShowHistoryRatingCommand(string description, Topic topic, IUserDB userDB) : base(
        description, topic, userDB) { }
}