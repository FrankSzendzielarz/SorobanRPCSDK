using System.Text;

public class CodeFile
{
    private readonly StringBuilder _builder = new StringBuilder();
    private int _indent = 0;
    private readonly string _indentString;
    private bool _needsIndent = true;
    private string _fileName;

    public bool IsRoot => _indent == 0;

    public CodeFile(string fileName,string indentString = "    ")
    {
        _indentString = indentString;
        _fileName = fileName;
    }

    public void Indent()
    {
        _indent++;
    }

    public void Unindent()
    {
        if (_indent > 0)
            _indent--;
    }

    public CodeFile AppendLine()
    {
        _builder.AppendLine();
        _needsIndent = true;
        return this;
    }

    public CodeFile AppendLine(string value)
    {
        WriteIndentIfNeeded();
        _builder.AppendLine(value);
        _needsIndent = true;
        return this;
    }

    public CodeFile Append(string value)
    {
        WriteIndentIfNeeded();
        _builder.Append(value);
        return this;
    }

    private void WriteIndentIfNeeded()
    {
        if (_needsIndent && _indent > 0)
        {
            for (int i = 0; i < _indent; i++)
            {
                _builder.Append(_indentString);
            }
            _needsIndent = false;
        }
    }

    public override string ToString()
    {
        return _builder.ToString();
    }

    public void OpenBlock()
    {
        AppendLine("{");
        Indent();
    }

    public void CloseBlock()
    {
        Unindent();
        AppendLine("}");
    }

    internal void Write()
    {
        CloseBlock(); //footer
        File.WriteAllText(_fileName, _builder.ToString());
    }
}