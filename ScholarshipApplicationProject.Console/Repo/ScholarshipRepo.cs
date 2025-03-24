using ScholarshipApplicationProject.Console.DbModels;

namespace ScholarshipApplicationProject.Console.Repo
{
    public class ScholarshipRepo
    {
        private readonly ScholarshipContext _context=new();

        public int GetNumberOfScholarship()
        {
            return _context.Scholarships.Count();
        }
    }
}
