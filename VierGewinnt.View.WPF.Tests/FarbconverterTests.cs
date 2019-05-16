using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using VierGewinnt.Core;
using Xunit;

namespace VierGewinnt.View.WPF.Tests
{
    public class FarbconverterTests
    {
        [Fact]
        public void FarbconverterGibtBrushZurückMitEntsprechenderRgbColor()
        {
            var farbe = new Farbe(255,128,0);
            var testTarget = new Farbconverter();

            var resulting = (SolidColorBrush)testTarget.Convert(farbe, null, null, null);

            var erwarteteFarbe = Color.FromRgb(farbe.Rot, farbe.Gruen, farbe.Blau);

            Assert.Equal(erwarteteFarbe, resulting.Color);

        }
    }
}
