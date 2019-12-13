using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace SwissLife.OSS.TodoGraphQL.Client
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class Queries
        : IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            67,
            85,
            55,
            90,
            89,
            114,
            53,
            53,
            65,
            101,
            71,
            105,
            67,
            52,
            119,
            98,
            67,
            88,
            78,
            98,
            66,
            103,
            61,
            61
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            103,
            101,
            116,
            32,
            123,
            32,
            103,
            101,
            116,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            105,
            100,
            32,
            115,
            116,
            97,
            116,
            117,
            115,
            32,
            116,
            105,
            116,
            108,
            101,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query get {
              get {
                id
                status
                title
              }
            }";
    }
}
