using System.Collections.Generic;

namespace VierGewinnt.Core.Tests
{
    public class LinieMock : Linie
    {
        public LinieMock(IReadOnlyList<Platz> plaetze) : base(plaetze)
        {
        }
    }
}