using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.ShowRatingMenuCommands;

public class ShowMixedRatingCommand : ShowRatingCommand
{
    public ShowMixedRatingCommand(string description, Topic topic, IUserDB userDB) : base(
        description, topic, userDB) { }
}