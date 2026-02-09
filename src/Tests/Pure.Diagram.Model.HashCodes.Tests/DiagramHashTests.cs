using System.Collections;
using Pure.Primitives.String.Operations;
using String = Pure.Primitives.String.String;

namespace Pure.Diagram.Model.HashCodes.Tests;

public sealed record DiagramHashTests
{
    [Fact]
    public void Determined()
    {
        Assert.Equal(
            "EABCFA85D8A59E1A5763D738BE5E8DDEB5091E015F0873D33CF5C36B0E5A48F7",
            new HexString(
                new DiagramHash(
                    new Diagram(
                        new String("edrfbhnju"),
                        new String("qwskoimj"),
                        new DiagramType(new String("yguvhf")),
                        [
                            new Series(
                                new String("frdtgnhji"),
                                new String("rdfesnjhiuk")
                            ),
                            new Series(
                                new String("dfvnjkhldfg"),
                                new String("nfjtrdkhigv")
                            ),
                        ]
                    )
                )
            ).TextValue
        );
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IEnumerable hash = new DiagramHash(
            new Diagram(
                new String("edrfbhnju"),
                new String("qwskoimj"),
                new DiagramType(new String("yguvhf")),
                [
                    new Series(new String("frdtgnhji"), new String("rdfesnjhiuk")),
                    new Series(new String("dfvnjkhldfg"), new String("nfjtrdkhigv")),
                ]
            )
        );

        ICollection<byte> bytes = new List<byte>(32);

        foreach (object b in hash)
        {
            bytes.Add((byte)b);
        }

        Assert.Equal(
            "EABCFA85D8A59E1A5763D738BE5E8DDEB5091E015F0873D33CF5C36B0E5A48F7",
            Convert.ToHexString([.. bytes])
        );
    }
}
