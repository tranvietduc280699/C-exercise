using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04Bai2
{
    internal class StudentUnivercity: StudentCollege
    {
        protected double score4;
        public StudentUnivercity() { }
        public StudentUnivercity(string name, int year,double score1, double score2, double score3, double score4) : 
            base(name,year,score1,score2,score3)
        {
            this.score4 = score4;
        }
        
    }
}
