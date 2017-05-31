using System;
using CalcoloVCI;

namespace UnitTests
{

    public interface IVCIBuilder
    {
        VCI Build();
    }

    public class NotSupportedVCIScenarioException : Exception
    {
    }

    public abstract class AbstractVCIScenario : IVCIBuilder
    {
        protected SezioneAnagrafica sezioneAnagrafica = new SezioneAnagrafica();
        protected SezioneCompliance sezioneCompliance = new SezioneCompliance();
        protected SezioneProcessi sezioneProcessi = new SezioneProcessi();
        protected SezioneTipoDati sezioneTipoDati = new SezioneTipoDati();
        protected SezioneImpatti sezioneImpatti = new SezioneImpatti();

        protected VCI vci = null;

        protected abstract void CreateScenario();

        public VCI Build()
        {
            CreateScenario();
            return new VCI(sezioneAnagrafica, sezioneCompliance, sezioneProcessi, sezioneTipoDati, sezioneImpatti);
        }
    }
}