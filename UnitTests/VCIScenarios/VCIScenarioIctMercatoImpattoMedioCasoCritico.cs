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
            sa.AmbitoTecnologico(
                DomandeRisposte.Anagrafica.Ambito.BusinessICTMercato
                );

            sa.DomandaAppartenenzaRealtaCritiche(
                DomandeRisposte.Anagrafica.Risposta.Si
                );

            // Sezione Compliance
            sc.ImpostaDomandaQuestionario(
                DomandeRisposte.Compliance.Perimetro.InformazioniPrivilegiate,
                DomandeRisposte.Compliance.Risposta.Si
                );
            sc.ImpostaDomandaQuestionario(
                DomandeRisposte.Compliance.Perimetro.CookieAnalyticsTerzeParti,
                DomandeRisposte.Compliance.Risposta.Si
                );

            // Sezione Processi
            sp.ImpostaDomandaQuestionario(
                DomandeRisposte.Processi.Domanda.HumanResourcesManagement,
                DomandeRisposte.Processi.Risposta.Influente
                );

            // Sezione Tipo Dati
            st.ImpostaDomandaQuestionario(
                DomandeRisposte.TipoDati.Perimetro.NO196,
                DomandeRisposte.TipoDati.Risposta.Si
                );

            // Sezione Impatti
            si.ImpostaRID(
                DomandeRisposte.Impatti.Riservatezza.Medio,
                DomandeRisposte.Impatti.Integrita.Medio,
                DomandeRisposte.Impatti.Disponibilita.MaggioreDiUnaSettimana
                );
        }
    }
}
