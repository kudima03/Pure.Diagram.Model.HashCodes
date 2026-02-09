using System.Collections;
using Pure.Diagram.Model.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;

namespace Pure.Diagram.Model.HashCodes;

public sealed record SeriesHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
    [
        187,
        65,
        156,
        1,
        152,
        18,
        109,
        121,
        153,
        52,
        201,
        48,
        106,
        128,
        117,
        242,
    ];

    private readonly ISeries _series;

    public SeriesHash(ISeries series)
    {
        _series = series;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix
                .Concat(new DeterminedHash(_series.Label))
                .Concat(new DeterminedHash(_series.Source))
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
