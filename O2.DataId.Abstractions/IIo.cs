namespace O2.DataId.Abstractions;

public interface IIo
{
    Span<byte> Read(string filename);
    
    void Write(string filename, ReadOnlySpan<byte> data);
    
    ReadOnlySpan<string> Args { get; set; }
    
    void Print(string text);
    
    public void PrintLn(string text)
    {
        Print(text);
        Print("\n");
    }
}