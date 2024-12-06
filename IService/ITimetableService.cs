using Dynamic_Time_Table_Generator.Models;

namespace Dynamic_Time_Table_Generator.IService
{
    public interface ITimetableService
    {
        List<List<string>> GenerateTimetable(TimeTableViewModel model);
        bool ValidateTotalSubjectHours(TimeTableViewModel model);
    }
}
