using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDetailsApp_List_.Model
{
    internal class Professor
    {
        public int ProfessorId { get; set; }
        public string ProfessorName { get; set; }

        public Professor(int profId, string profName)
        {
            ProfessorId = profId;
            ProfessorName = profName;
        }
    }
}
