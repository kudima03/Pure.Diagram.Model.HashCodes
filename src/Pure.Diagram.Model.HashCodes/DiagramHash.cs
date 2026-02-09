using System.Collections;
using Pure.Diagram.Model.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;

namespace Pure.Diagram.Model.HashCodes;

public sealed record DiagramHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
    [
        187,
        65,
        156,
        1,
        48,
        70,
        147,
        118,
        139,
        188,
        157,
        27,
        173,
        161,
        227,
        186,
    ];

    private readonly IDiagram _diagram;

    public DiagramHash(IDiagram diagram)
    {
        _diagram = diagram;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix
                .Concat(new DeterminedHash(_diagram.Title))
                .Concat(new DeterminedHash(_diagram.Description))
                .Concat(new DiagramTypeHash(_diagram.Type))
                .Concat(
                    new DeterminedHash(_diagram.Series.Select(x => new SeriesHash(x)))
                )
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
