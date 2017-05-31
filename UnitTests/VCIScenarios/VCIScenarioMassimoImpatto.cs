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

    public class VCIScenarioMassimoImpatto : AbstractVCIScenario
    {
        
        protected override void CreateScenario()
        {
            // Sezione Anagrafica
            sezioneAnagrafica.DomandaAppartenenzaRealtaCritiche(
                Risposta.Si
                );

            // Sezione Compliance
            sezioneCompliance.ImpostaDomandaQuestionario(
                PerimetroCompliance.Magistratura, 
                RispostaCompliance.Si
                );

            // Sezione Processi
            sezioneProcessi.ImpostaDomandaQuestionario(
                DomandaProcessi.CustomerRelationshipManagement,
                RispostaProcessi.Determinante
                );

            // Sezione Tipo Dati
            sezioneTipoDati.ImpostaDomandaQuestionario(
                PerimetroTipoDati.DatiSensibili,
                RispostaTipoDati.Si
                );

            sezioneImpatti.ImpostaRID(
                Riservatezza.Alto,
                Integrita.Alto,
                Disponibilita.MassimaPriorita
                );

        }
    }
}