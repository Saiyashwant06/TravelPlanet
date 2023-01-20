using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Repistroy
{
    public class ProjectDetail : IProject
    {
        ProjectEntities3 max = new ProjectEntities3();

        public string Updateteam(EmpModel on)
        {
            throw new NotImplementedException();
        }

        string IProject.Updateteam(EmpModel on)
        {
            var Projectlist = max.TLtables.Where(s => s.TLName == on.TLName);
            if (Projectlist != null)
            {
                max.Emptables.Add(new Emptable {
                    EmpId = on.EmpId,
                    EmpName = on.EmpName,
                    TLName = on.TLName,
                    DOJ = on.DOJ
                });

            }
            var team = max.Projecttables.Where(e => e.TLName == on.TLName).FirstOrDefault();
            if (team != null)
            {
                team.TeamSize++;
            } 
            max.SaveChanges();
            max.Dispose();
            return "Team Mate Added";

        }

        /* var fg = max.Emptables.Where(e => e.EmpId == on.EmpId).FirstOrDefault();
         if (fg != null)
         {
             max.Emptables.Remove(fg);
         };

         var kd = max.Emptables.Find(on.EmpId);
         if(kd == null)
         {
             team.TeamSize--;
         }
       */
        List<Joins> IProject.Getdatajoin()
        {
            List<Joins> ser = (from EmpModel in max.Emptables
                               from ProjectModel in max.Projecttables where EmpModel.TLName == ProjectModel.TLName
                               select new Joins()
                               {
                                   EmpId = EmpModel.EmpId,
                                   EmpName = EmpModel.EmpName,
                                   ProjectName = ProjectModel.ProjectName,
                                   TLName = ProjectModel.TLName
                               }).ToList<Joins>();
            max.SaveChanges();
            max.Dispose();
            return ser;
        }

       /* List<ProjectModel> IProject.Getteam()
        {*/
            /*
            List<Joins> it = (from ProjectModel in max.Projecttables
                              group ProjectModel by ProjectModel.TeamSize into 
                              select new
                              {
                                  
                              });
*/
            /*var it = max.Projecttables.GroupBy(ProjectModel => ProjectModel.TLName)
                .Select(s => new ProjectModel() 
                {
                    P

                })
                .ToList<ProjectModel>();
            */

           /* List<ProjectviewModel> gh = max.Projecttables.GroupBy(s => s.TeamSize)
                .Select(s => s.FirstOrDefault()).Select(s => new ProjectviewModel
                {
                    ProjectID = s.ProjectID,
                    ProjectName = s.ProjectName,
                    TLName = s.TeamSize,
                    TeamSize = s.TeamSize

                }).ToList<ProjectviewModel>();
            max.SaveChanges();
            max.Dispose();
            return gh;*/

            

        }
    }