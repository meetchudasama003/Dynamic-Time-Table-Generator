namespace Dynamic_Time_Table_Generator.Models
{
    public class TimeTableViewModel
    {
        public int NoOfWorkingDays { get; set; }
        public int NoOfSubjectsPerDay { get; set; }
        public int TotalSubjects { get; set; }
        public int TotalHours { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        public List<List<string>> Timetable { get; set; }
    }

    public class Subject
    {
        public string Name { get; set; }
        public int Hours { get; set; }
    }

}
