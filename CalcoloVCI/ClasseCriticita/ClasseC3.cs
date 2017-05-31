namespace CalcoloVCI.ClasseCriticita
{
    public class ClasseC3 : AbstractClasseCriticita
    {

        public ClasseC3(): base(new Range(">=", 425, "<=", 1250))
        {   
                     
        }

        public override string ToString()
        {
            return "C3";
        }

    }
}
