using CalcoloVCI;
using DomandeRisposte.Anagrafica;
using DomandeRisposte.Impatti;

namespace UnitTests
{

    #region short-namespaces
    using PerimetroCompliance = DomandeRisposte.Compliance.Perimetro;
    using RispostaCompliance = DomandeRisposte.Compliance.Risposta;

    using DomandaProcessi = DomandeRisposte.Processi.Domanda;
    using RispostaProcessi = DomandeRisposte.Processi.Risposta;

    using PerimetroTipoDati = DomandeRisposte.TipoDati.Perimetro;
    using RispostaTipoDati = DomandeRisposte.TipoDati.Risposta;
    #endregion

    public class VCIScenarioIctMercatoImpattoMedioCasoCritico : AbstractVCIScenario
    {
        protected override void CreateScenario()
        {
            // Sezione Anagrafica
            sezioneAnagrafica.ImpostaAmbitoTecnologico(
                Ambito.BusinessICTMercato
                );

            sezioneAnagrafica.DomandaAppartenenzaRealtaCritiche(
                Risposta.Si
                );

            // Sezione Compliance
            sezioneCompliance.ImpostaDomandaQuestionario(
                PerimetroCompliance.InformazioniPrivilegiate,
                RispostaCompliance.Si
                );
            sezioneCompliance.ImpostaDomandaQuestionario(
                PerimetroCompliance.CookieAnalyticsTerzeParti,
                RispostaCompliance.Si
                );

            // Sezione Processi
            sezioneProcessi.ImpostaDomandaQuestionario(
                DomandaProcessi.HumanResourcesManagement,
                RispostaProcessi.Influente
                );

            // Sezione Tipo Dati
            sezioneTipoDati.ImpostaDomandaQuestionario(
                PerimetroTipoDati.NO196,
                RispostaTipoDati.Si
                );

            // Sezione Impatti
            sezioneImpatti.ImpostaRID(
                Riservatezza.Medio,
                Integrita.Medio,
                Disponibilita.MaggioreDiUnaSettimana
                );
        }
    }
}
