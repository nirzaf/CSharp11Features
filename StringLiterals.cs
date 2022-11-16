namespace CSharp11Features;

public class StringLiterals
{
    public string EscapeStringOld()
    {
        //Old way to escape a double quote in a string
        return "<step number=\"3\">Connect A to B.</step>";
    }

    public string EscapeStringNew()
    {
        //New way to escape a double quote in a string
        return """<step number="3">Connect A to B.</step>""";
    }

    public string JsonAsTextOld()
    {
        //Old way to create a string with a lot of double quotes
        return "{ \"name\": \"John\", \"age\": 30, \"car\": null }";
    }

    public string JsonAsTextNew()
    {
        //New way to create a string with a lot of double quotes
        return """
        {
        "menu": { 
        "id": "file", 
        "value": "File", 
        "popup": {
        "menuitem": [
            {"value": "New", "onclick": "CreateNewDoc()"}, 
            {"value": "Open", "onclick": "OpenDoc()"}, 
            {"value": "Close", "onclick": "CloseDoc()"} 
                ]}
            }
        }
        """;
    }

    public string JsonWithStringInterpolationNew()
    {
        //New way to create a string with a lot of double quotes and string interpolation
        string name = "John";
        int age = 30;
        string car = "BMW";
        
        return $$"""
                {
                "name": "{{name}}", 
                "age": "{{age}}", 
                "car": "{{car}}" 
                }
            """;
    }
}