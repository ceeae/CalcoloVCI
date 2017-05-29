using Xunit;
using FluentAssertions;
using CalcoloVCI;

using DomandeRisposte.Impatti;

namespace UnitTests
{
    public class SezioneImpattiTests
    {
        private readonly SezioneImpatti sezioneImpatti;

        public SezioneImpattiTests()
        {
            sezioneImpatti = new SezioneImpatti();
        }

        [Fact]
        public void CalcolaRID_Default_Return2()
        {
            int rid = sezioneImpatti.rid;

            rid.Should().Be(2);
        }

        [Theory]
        [InlineData(
            Riservatezza.Basso, 
            Integrita.Medio, 
            Disponibilita.MaggioreDiUnaSettimana
         )]
        [InlineData(
            Riservatezza.Medio,
            Integrita.Alto,
            Disponibilita.MinoreDiUnOra
         )]
        public void CalcolaRID(int r, int i, int d)
        {
            sezioneImpatti.ImpostaRID(r, i, d);
            int rid = sezioneImpatti.rid;

            rid.Should().Be(r + i + d);
        }

        [Theory]
        [InlineData(Riservatezza.Basso, Integrita.Basso, Disponibilita.MaggioreDiUnaSettimana, 1)]
        [InlineData(Riservatezza.Medio, Integrita.Alto, Disponibilita.MinoreDiUnGiorno, 3)]
        [InlineData(Riservatezza.Alto, Integrita.Medio, Disponibilita.MinoreDiUnOra, 4)]
        [InlineData(Riservatezza.Alto, Integrita.Alto, Disponibilita.MassimaPriorita, 5)]
        public void CalcolaVB(int r, int i, int d, int vb)
        {
            sezioneImpatti.ImpostaRID(r, i, d);

            int result = sezioneImpatti.CalcolaVb();

            result.Should().Be(vb);
        }
    }
}
