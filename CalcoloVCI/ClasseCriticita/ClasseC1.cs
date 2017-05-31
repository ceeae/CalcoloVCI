namespace CalcoloVCI.ClasseCriticita
{
    public class ClasseC1 : AbstractClasseCriticita
    {

        public ClasseC1() : base(new Range(">=", 2.24, "<", 200))
        {

        }

        public override string ToString()
        {
            return "C1";
        }
    }
}
