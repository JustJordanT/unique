namespace unique.lib;

public class Unique
{

    private static Random random = new Random();

    /// <summary>
    ///  Initializes a new instance of UUID.
    /// </summary>
    /// <param name="maxNum"></param>
    /// <returns>Returns a int UUID</returns>
    public static string GetId()
    {
        var uuid = random.Next() + "-" + random.Next();
        return uuid;
    }
}