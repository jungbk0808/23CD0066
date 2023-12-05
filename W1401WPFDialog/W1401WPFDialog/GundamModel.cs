using System.Security.Cryptography.X509Certificates;

namespace W1401WPFDialog;

public class GundamModel
{
    public GundamModel(string name, string model, string party) => 
        (Name, Model, Party) = (name, model, party);

    public string Name { get; }
    public string Model { get; }
    public string Party { get; }

}
