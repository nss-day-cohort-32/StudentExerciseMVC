using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercises.Models.ViewModels
{
    public class InstructorCreateViewModel
    {
        public Instructor Instructor { get; set; }
        public List<SelectListItem> Cohorts { get; set; }

        public InstructorCreateViewModel(List<Cohort> cohortList)
        {

            Cohorts = cohortList
                .Select(cohort => new SelectListItem
                {
                    Text = cohort.Name,
                    Value = cohort.Id.ToString()
                })
                .ToList();

            Cohorts.Insert(0, new SelectListItem
            {
                Text = "Choose cohort...",
                Value = "0"
            });
        }
    }
}
