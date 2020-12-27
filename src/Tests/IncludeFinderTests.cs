﻿using System.Threading.Tasks;
using MarkdownSnippets;
using VerifyXunit;
using Xunit;

[UsesVerify]
public class IncludeFinderTests
{
    [Fact]
    public Task Simple()
    {
        IncludeFinder finder = new(_ => true);
        var includes = finder.ReadIncludes("IncludeFinder");
        return Verifier.Verify(includes);
    }
}