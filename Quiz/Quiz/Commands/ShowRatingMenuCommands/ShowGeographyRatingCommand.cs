using Quiz.Commands.ShowRatingMenuCommands;
using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.ShowRatingCommands;

public class ShowGeographyRatingCommand : ShowRatingCommand
{
    public ShowGeographyRatingCommand(
        string description, Topic topic, IUserDB userDB) : base(
            description, topic, userDB) { }
}