
namespace CalcoloVCI.ClasseCriticita
{

    public interface IClasseCriticita
    {
        bool match(double vci);
    }


    public abstract class AbstractClasseCriticita : IClasseCriticita
    {
        public abstract bool match(double vci);

        public abstract override string ToString();
    }
}
