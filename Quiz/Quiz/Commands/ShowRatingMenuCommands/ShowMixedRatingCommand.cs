using Quiz.Commands.ShowRatingMenuCommands;
using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.ShowRatingCommands;

public class ShowMixedRatingCommand : ShowRatingCommand
{
    public ShowMixedRatingCommand(
        string description, Topic topic, IUserDB userDB) : base(
            description, topic, userDB) { }
}