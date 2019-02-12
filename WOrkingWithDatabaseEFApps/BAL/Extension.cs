using CustomClassLibrary;

namespace WOrkingWithDatabaseEFApps.BAL
{
    static class Extension
    {
        public static string ExtensionMethod(this PrintSomeValue obj)
        {
            return "Hello Extension Methods";
        }
    }
}