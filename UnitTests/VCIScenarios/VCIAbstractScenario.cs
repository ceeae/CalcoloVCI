using CalcoloVCI;

namespace UnitTests
{
    public abstract class VCIAbstractScenario : IVCIBuilder
    {
        protected SezioneAnagrafica sa = new SezioneAnagrafica();
        protected SezioneCompliance sc = new SezioneCompliance();
        protected SezioneProcessi sp = new SezioneProcessi();
        protected SezioneTipoDati st = new SezioneTipoDati();
        protected SezioneImpatti si = new SezioneImpatti();

        protected VCI vci = null;

        protected abstract void CreateScenario();

        public VCI Build()
        {
            CreateScenario();
            return vci;
        }
    }
}