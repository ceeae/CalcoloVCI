using CalcoloVCI;

namespace UnitTests
{
    public class VCIScenarioMassimoImpatto : VCIAbstractScenario
    {
        
        protected override void CreateScenario()
        {
            // Sezione Anagrafica
            sa.AppartenenzaRealtaCritiche(DomandeRisposte.Anagrafica.Risposta.Si);

            // Sezione Compliance
            sc.ImpostaQuestionario(
                DomandeRisposte.Compliance.Perimetro.Magistratura, 
                DomandeRisposte.Compliance.Risposta.Si
                );

            // Sezione Processi
            sp.ImpostaQuestionario(
                DomandeRisposte.Processi.Domanda.CustomerRelationshipManagement,
                DomandeRisposte.Processi.Risposta.Determinante
                );

            // Sezione Tipo Dati
            st.ImpostaQuestionario(
                DomandeRisposte.TipoDati.Perimetro.DatiSensibili,
                DomandeRisposte.TipoDati.Risposta.Si
                );

            si.ImpostaRID(
                DomandeRisposte.Impatti.Riservatezza.Alto,
                DomandeRisposte.Impatti.Integrita.Alto,
                DomandeRisposte.Impatti.Disponibilita.MassimaPriorita
                );

            vci = new VCI(sa, sc, sp, st, si);
        }
    }
}