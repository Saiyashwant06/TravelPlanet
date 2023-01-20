using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Repistroy
{
     public interface IProject
    {
        string Updateteam(EmpModel on);

        List<Joins> Getdatajoin();
/*        List<ProjectModel> Getteam();
*/    }

}
