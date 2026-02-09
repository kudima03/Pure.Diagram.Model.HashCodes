using System.Collections;
using Pure.Diagram.Model.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;

namespace Pure.Diagram.Model.HashCodes;

public sealed record DiagramTypeHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
    [
        186,
        65,
        156,
        1,
        12,
        212,
        46,
        127,
        140,
        30,
        14,
        186,
        203,
        196,
        27,
        197,
    ];

    private readonly IDiagramType _diagramType;

    public DiagramTypeHash(IDiagramType diagramType)
    {
        _diagramType = diagramType;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix.Concat(new DeterminedHash(_diagramType.Name))
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
