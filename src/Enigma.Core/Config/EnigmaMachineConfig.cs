namespace Enigma.Core.Config;

public class EnigmaMachineConfig
{
    public CharacterSet CharacterSet { get; set; } = CharacterSet.Default;

    public RotorConfig LeftRotor { get; set; } = new();

    public RotorConfig MiddleRotor { get; set; } = new();

    public RotorConfig RightRotor { get; set; } = new();

    public string Reflector { get; set; } = string.Empty;

    public string Plugboard { get; set; } = string.Empty;
}