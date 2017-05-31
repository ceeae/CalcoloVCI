namespace CalcoloVCI.ClasseCriticita
{
    public class ClasseC2 : AbstractClasseCriticita
    {

        public ClasseC2() : base(new Range(">=", 200, "<", 425))
        {

        }

        public override string ToString()
        {
            return "C2";
        }

    }
}
