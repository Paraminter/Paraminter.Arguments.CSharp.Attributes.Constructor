namespace Paraminter.Arguments.CSharp.Attributes.Constructor.Models;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Paraminter.Associators.Models;

/// <summary>Represents syntactic data about a normal C# attribute constructor argument.</summary>
public interface INormalCSharpAttributeConstructorArgumentData
    : IArgumentData
{
    /// <summary>The syntactic data about the normal C# attribute constructor argument.</summary>
    public abstract AttributeArgumentSyntax SyntacticArgument { get; }
}
