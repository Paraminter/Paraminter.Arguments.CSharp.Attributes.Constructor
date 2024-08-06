namespace Paraminter.Arguments.CSharp.Attributes.Constructor.Models;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Paraminter.Associators.Models;

/// <summary>Represents syntactic data about <see langword="params"/> C# attribute constructor arguments.</summary>
public interface IParamsCSharpAttributeConstructorArgumentData
    : IArgumentData
{
    /// <summary>The syntactic data about the <see langword="params"/> C# attribute constructor arguments.</summary>
    public abstract AttributeArgumentSyntax SyntacticArguments { get; }
}
