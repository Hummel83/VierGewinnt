using System;
using System.Collections.Generic;
using System.Text;
using VierGewinnt.Core;


namespace VierGewinnt.Core.Tests
{
    public class LinieMock : Linie
    {
        public LinieMock(IReadOnlyList<Platz> plaetze) : base(plaetze)
        {
        }
    }
}
