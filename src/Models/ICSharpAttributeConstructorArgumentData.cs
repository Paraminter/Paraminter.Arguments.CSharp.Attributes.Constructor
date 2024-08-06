namespace Paraminter.Arguments.CSharp.Attributes.Constructor.Models;

using Microsoft.CodeAnalysis.CSharp.Syntax;

/// <summary>Represents syntactic data about a C# attribute constructor argument.</summary>
public interface ICSharpAttributeConstructorArgumentData
{
    /// <summary>The syntactic data about the C# attribute constructor argument.</summary>
    public abstract AttributeArgumentSyntax SyntacticArgument { get; }
}
