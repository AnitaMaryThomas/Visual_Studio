using NewProject_23.Types;
namespace NewProject_23.Entities
{
    internal class Exam
    {
        public ExamTypes Type { get; set; }
        public Subject Subject { get; set; }
        public int MarkScored { get; set; }
    }

}
