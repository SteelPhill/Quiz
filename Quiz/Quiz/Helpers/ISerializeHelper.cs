namespace Quiz.Helpers;

public interface ISerializeHelper
{
    void Serialize(object obj, string path);
    T Deserialize<T>(string path);
}