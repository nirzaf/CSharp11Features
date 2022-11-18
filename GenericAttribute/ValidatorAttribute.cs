namespace CSharp11Features.GenericAttribute;
public class ValidatorAttribute<TValidator> : Attribute where TValidator : IValidator
{
}

public interface IValidator
{
}

public class UserValidator : IValidator
{
    
}