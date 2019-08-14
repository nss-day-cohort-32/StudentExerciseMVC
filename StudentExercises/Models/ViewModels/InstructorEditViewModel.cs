using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercises.Models.ViewModels
{
    public class InstructorEditViewModel
    {
        public Instructor Instructor { get; set; }

        public List<SelectListItem> Cohorts { get; set; }

        public InstructorEditViewModel() { }

        public InstructorEditViewModel(Instructor instructor, List<Cohort> cohortList)
        {
            Instructor = instructor;
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
