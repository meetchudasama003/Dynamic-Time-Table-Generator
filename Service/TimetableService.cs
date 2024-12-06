using Dynamic_Time_Table_Generator.IService;
using Dynamic_Time_Table_Generator.Models;

namespace Dynamic_Time_Table_Generator.Service
{
    public class TimetableService : ITimetableService
    {
        public List<List<string>> GenerateTimetable(TimeTableViewModel model)
        {
            var timetable = new List<List<string>>();
            var subjects = model.Subjects.Select(s => s.Name).ToList();

            for (int i = 0; i < model.NoOfSubjectsPerDay; i++)
            {
                var row = new List<string>();
                for (int j = 0; j < model.NoOfWorkingDays; j++)
                {
                    row.Add(subjects[(i + j) % model.TotalSubjects]);
                }
                timetable.Add(row);
            }

            return timetable;
        }

        public bool ValidateTotalSubjectHours(TimeTableViewModel model)
        {
            int totalSubjectHours = model.Subjects.Sum(s => s.Hours);
            return totalSubjectHours == model.TotalHours;
        }
    }
}
