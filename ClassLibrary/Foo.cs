using System.Configuration;

namespace ClassLibrary;

public class Foo
{
    public static string Bar = ConfigurationManager.AppSettings["setting"];
}