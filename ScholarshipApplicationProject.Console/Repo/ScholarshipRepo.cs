using ScholarshipApplicationProject.Console.DbModels;
using ScholarshipApplicationProject.Console.Models;

namespace ScholarshipApplicationProject.Console.Repo
{
    public class ScholarshipRepo
    {
        private readonly ScholarshipContext _context=new();

        public int GetNumberOfScholarship()
        {
            return _context.Scholarships.Count();
        }

        public void AddScholarship(ScholarshipApplicant scholarshipApplicant)
        {
            _context.Add(scholarshipApplicant);
            _context.SaveChanges();
        }

        public void RemoveSholarship(string email)
        {
            var s=_context.Scholarships.FirstOrDefault(sch => sch.Email == email);
            if (s != null)
            {
                _context.Remove(s);
                _context.SaveChanges();
            }
        }
    }
}
