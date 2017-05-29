using CalcoloVCI;

namespace UnitTests
{
    public class VCIScenarioICTMercatoImpattoMedio : VCIAbstractScenario
    {

        protected override void CreateScenario()
        {
            // Sezione Anagrafica
            sa.AmbitoTecnologico(
                DomandeRisposte.Anagrafica.Ambito.BusinessICTMercato
                );

            // Sezione Compliance
            sc.ImpostaQuestionario(
                DomandeRisposte.Compliance.Perimetro.InformazioniPrivilegiate,
                DomandeRisposte.Compliance.Risposta.Si
                );
            sc.ImpostaQuestionario(
                DomandeRisposte.Compliance.Perimetro.CookieAnalyticsTerzeParti,
                DomandeRisposte.Compliance.Risposta.Si
                );

            // Sezione Processi
            sp.ImpostaQuestionario(
                DomandeRisposte.Processi.Domanda.HumanResourcesManagement,
                DomandeRisposte.Processi.Risposta.Influente
                );

            // Sezione Tipo Dati
            st.ImpostaQuestionario(
                DomandeRisposte.TipoDati.Perimetro.NO196,
                DomandeRisposte.TipoDati.Risposta.Si
                );

            // Sezione Impatti
            si.ImpostaRID(
                DomandeRisposte.Impatti.Riservatezza.Medio,
                DomandeRisposte.Impatti.Integrita.Medio,
                DomandeRisposte.Impatti.Disponibilita.MinoreDiUnGiorno
                );

            vci = new VCI(sa, sc, sp, st, si);
        }
    }
}