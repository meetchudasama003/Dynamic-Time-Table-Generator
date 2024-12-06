using Dynamic_Time_Table_Generator.IService;
using Dynamic_Time_Table_Generator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dynamic_Time_Table_Generator.Controllers
{
    public class TimetableController : Controller
    {
        private readonly ITimetableService _timetableService;

        public TimetableController(ITimetableService timetableService)
        {
            _timetableService = timetableService;
        }
        //TimeTable Form 
        public IActionResult TimetableForm()
        {
            return View();
        }

        //SubjectHour Input Form 
        [HttpPost]
        public IActionResult GenerateSubjectInput(TimeTableViewModel model)
        {
            model.TotalHours = model.NoOfWorkingDays * model.NoOfSubjectsPerDay;
            return View("SubjectHourForm", model); 
        }

        //TimeTable View
        [HttpPost]
        public IActionResult GenerateTimeTable(TimeTableViewModel model)
        {
            // Validate if total subject hours match total hours
            if (!_timetableService.ValidateTotalSubjectHours(model))
            {
                ModelState.AddModelError("", "The total hours for subjects do not match the total hours for the week.");
                return View("SubjectHourInput", model);
            }

            // Generate timetable
            model.Timetable = _timetableService.GenerateTimetable(model);
            // Pass Model To view
            return View("TimetableView", model); 
        }
    }

}
