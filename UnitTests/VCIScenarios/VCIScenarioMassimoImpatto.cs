using CalcoloVCI;

namespace UnitTests
{
    public class VCIScenarioMassimoImpatto : VCIAbstractScenario
    {
        
        protected override void CreateScenario()
        {
            // Sezione Anagrafica
            sezioneAnagrafica.DomandaAppartenenzaRealtaCritiche(
                DomandeRisposte.Anagrafica.Risposta.Si
                );

            // Sezione Compliance
            sezioneCompliance.ImpostaDomandaQuestionario(
                DomandeRisposte.Compliance.Perimetro.Magistratura, 
                DomandeRisposte.Compliance.Risposta.Si
                );

            // Sezione Processi
            sezioneProcessi.ImpostaDomandaQuestionario(
                DomandeRisposte.Processi.Domanda.CustomerRelationshipManagement,
                DomandeRisposte.Processi.Risposta.Determinante
                );

            // Sezione Tipo Dati
            sezioneTipoDati.ImpostaDomandaQuestionario(
                DomandeRisposte.TipoDati.Perimetro.DatiSensibili,
                DomandeRisposte.TipoDati.Risposta.Si
                );

            sezioneImpatti.ImpostaRID(
                DomandeRisposte.Impatti.Riservatezza.Alto,
                DomandeRisposte.Impatti.Integrita.Alto,
                DomandeRisposte.Impatti.Disponibilita.MassimaPriorita
                );

        }
    }
}