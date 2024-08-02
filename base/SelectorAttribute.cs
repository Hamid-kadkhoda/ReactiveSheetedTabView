
namespace Sysytem.ReactiveSheetedTabView;

public class SelectorAttribute: Attribute
{
    public string Title { get; set; }
    public Type? Component { get; set; }

    public SelectorAttribute(string title,object? component)
    {
        Title = title;
        Component = component!.GetType();
    }
}
