using System.Windows.Media;
using Xunit;

namespace VierGewinnt.View.WPF.Tests
{
    public class IstAnDerReiheZuBrushConverterTests
    {
        private IstAnDerReiheZuBrushConverter _testTarget;
        public IstAnDerReiheZuBrushConverterTests()
        {
             _testTarget = new IstAnDerReiheZuBrushConverter();
        }
        [Fact]
        public void ConverterGibtTransparentBrushZurueckWennWertFalschIst()
        {
            
            var brush = (SolidColorBrush)_testTarget.Convert(false, null, null, null);

            Assert.Equal(Colors.Transparent, brush.Color);
        }

        [Fact]
        public void ConverterGibtSilberBrushZurueckWennWertWahrIst()
        {
            
            var brush = (SolidColorBrush)_testTarget.Convert(true, null, null, null);

            Assert.Equal(Colors.Silver, brush.Color);
        }
    }
}