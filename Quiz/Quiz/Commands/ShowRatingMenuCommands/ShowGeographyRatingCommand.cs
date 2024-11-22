using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.ShowRatingMenuCommands;

public class ShowGeographyRatingCommand : ShowRatingCommand
{
    public ShowGeographyRatingCommand(string description, Topic topic, IUserDB userDB) : base(
        description, topic, userDB) { }
}