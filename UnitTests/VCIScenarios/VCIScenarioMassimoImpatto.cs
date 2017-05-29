using CalcoloVCI;

namespace UnitTests
{
    public class VCIScenarioMassimoImpatto : VCIAbstractScenario
    {
        
        protected override void CreateScenario()
        {
            // Sezione Anagrafica
            sa.DomandaAppartenenzaRealtaCritiche(
                DomandeRisposte.Anagrafica.Risposta.Si
                );

            // Sezione Compliance
            sc.ImpostaDomandaQuestionario(
                DomandeRisposte.Compliance.Perimetro.Magistratura, 
                DomandeRisposte.Compliance.Risposta.Si
                );

            // Sezione Processi
            sp.ImpostaDomandaQuestionario(
                DomandeRisposte.Processi.Domanda.CustomerRelationshipManagement,
                DomandeRisposte.Processi.Risposta.Determinante
                );

            // Sezione Tipo Dati
            st.ImpostaDomandaQuestionario(
                DomandeRisposte.TipoDati.Perimetro.DatiSensibili,
                DomandeRisposte.TipoDati.Risposta.Si
                );

            si.ImpostaRID(
                DomandeRisposte.Impatti.Riservatezza.Alto,
                DomandeRisposte.Impatti.Integrita.Alto,
                DomandeRisposte.Impatti.Disponibilita.MassimaPriorita
                );

        }
    }
}