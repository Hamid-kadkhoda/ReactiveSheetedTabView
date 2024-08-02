
using System.Reflection;

namespace System.ReactiveSheetedTabView;

public static class GetComponentType
{

    private static Assembly assembly => Assembly.GetExecutingAssembly();

    public static Type FromAssemblyBy(string Key)
    {
        var type = assembly.GetTypes().FirstOrDefault(c => c.Name == Key) ?? "".GetType();
        return type;
    }
}
