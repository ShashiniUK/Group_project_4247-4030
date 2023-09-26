using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    class Modules
    {
        public string ModuleCode { get; set; }

        public string ModuleName { get; set; }

        public int Credit { get; set; }

        public string TeacherInCharge { get; set; }

        public Modules(string moduleCode, string moduleName, int credit, string teacherInCharge)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            Credit = credit;
            TeacherInCharge = teacherInCharge;
        }

        public Modules()
        {
        }
    }
}
