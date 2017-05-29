using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.VCIScenarios
{
    public class VCIScenarioIctMercatoImpattoMedioCasoCritico : VCIAbstractScenario
    {
        protected override void CreateScenario()
        {
            // Sezione Anagrafica
            sezioneAnagrafica.ImpostaAmbitoTecnologico(
                DomandeRisposte.Anagrafica.Ambito.BusinessICTMercato
                );

            sezioneAnagrafica.DomandaAppartenenzaRealtaCritiche(
                DomandeRisposte.Anagrafica.Risposta.Si
                );

            // Sezione Compliance
            sezioneCompliance.ImpostaDomandaQuestionario(
                DomandeRisposte.Compliance.Perimetro.InformazioniPrivilegiate,
                DomandeRisposte.Compliance.Risposta.Si
                );
            sezioneCompliance.ImpostaDomandaQuestionario(
                DomandeRisposte.Compliance.Perimetro.CookieAnalyticsTerzeParti,
                DomandeRisposte.Compliance.Risposta.Si
                );

            // Sezione Processi
            sezioneProcessi.ImpostaDomandaQuestionario(
                DomandeRisposte.Processi.Domanda.HumanResourcesManagement,
                DomandeRisposte.Processi.Risposta.Influente
                );

            // Sezione Tipo Dati
            sezioneTipoDati.ImpostaDomandaQuestionario(
                DomandeRisposte.TipoDati.Perimetro.NO196,
                DomandeRisposte.TipoDati.Risposta.Si
                );

            // Sezione Impatti
            sezioneImpatti.ImpostaRID(
                DomandeRisposte.Impatti.Riservatezza.Medio,
                DomandeRisposte.Impatti.Integrita.Medio,
                DomandeRisposte.Impatti.Disponibilita.MaggioreDiUnaSettimana
                );
        }
    }
}
