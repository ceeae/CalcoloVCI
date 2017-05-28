using Xunit;
using FluentAssertions;

using CalcoloVCI;

namespace UnitTests
{

    public class VCITests
    {
        [Fact]
        public void CalcolaVCI_NoImpatti_Risultato()
        {
            SezioneAnagrafica sa = new SezioneAnagrafica();
            SezioneCompliance sc  = new SezioneCompliance();
            SezioneProcessi sp = new SezioneProcessi();
            SezioneTipoDati st = new SezioneTipoDati();
            SezioneImpatti si = new SezioneImpatti();
            VCI vci = new VCI(sa,sc,sp,st,si);

            double result = vci.CalcolaVCI();

            result.Should().Be(2.24);
        }
    }
}
