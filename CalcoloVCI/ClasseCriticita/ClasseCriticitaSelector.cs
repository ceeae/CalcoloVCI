using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalcoloVCI.ClasseCriticita
{
    class ClasseCriticitaSelector
    {
        private List<AbstractClasseCriticita> classiCriticita = new List<AbstractClasseCriticita>();

        public ClasseCriticitaSelector()
        {
            classiCriticita.Add(new ClasseC1());
            classiCriticita.Add(new ClasseC2());
            classiCriticita.Add(new ClasseC3());
        }

        public AbstractClasseCriticita ClasseCriticita(double vci)
        {
            foreach (var classe in classiCriticita)
            {
                if (classe.match(vci))
                {
                    return classe;
                }
            }
            return null; // :( ODD but avoid throw-an-exception-alternative to be handled by client            
        }
    }
}
