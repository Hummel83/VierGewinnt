using System.Collections.Generic;
using VierGewinnt.Core;
using Xunit;

namespace VierGewinnt.View.WPF.Tests
{
    public class SpielerViewModelTests
    {
        [Fact]
        public void ViewModelGibtBenachrichtigungWennIstAnDerReiheGeändertWird()
        {
            var testTarget = new SpielerViewModel(new Spieler("Hallo", new List<Spielstein>(), new Farbe(0, 0, 125)));
            var callCount = 0;
            testTarget.PropertyChanged += (sender, args) => callCount++;

            testTarget.IstAnDerReihe = !testTarget.IstAnDerReihe;

            Assert.Equal(1, callCount);
        }
    }
}