namespace TPDataGrid;

public partial class Idol
{
    public Idol(string name, string group, string position) =>
        (Name, Group, Position) = (name, group, position);

    public string Name { get; }
    public string Group { get; }
    public string Position { get; }
}
