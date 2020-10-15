using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Turntabl
{
     class Instructor : Person
    {
        List<double> evaluation;
        public override double Rating {
            get
               {
                return evaluation.Average();
                }
            }

        public Instructor(string name, List<double> evaluation) :base(name)
        {
            this.evaluation = evaluation;
        }
      }
   }

        
   

