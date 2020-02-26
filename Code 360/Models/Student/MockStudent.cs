using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class MockStudent : IStudentRepository
    {
        private List<Student> _studentList;

        public MockStudent()
        {
            
        }

        public Student AddStudent(Student _student)
        {
            _student.Id = _studentList.Max(r => r.Id) + 1;
            _studentList.Add(_student);
            return _student;
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return _studentList;
        }

        public Student GetStudent(int Id)
        {
            return _studentList.FirstOrDefault(w => w.Id == Id);
        }

        public Student RemoveStudent(int Id)
        {
            Student student = _studentList.FirstOrDefault(q => q.Id == Id);
            if (student != null)
            {
                _studentList.Remove(student);
            }
                return student;
        }

        public Student UpdateStudent(Student studentUpdate)
        {
            Student student = _studentList.FirstOrDefault(q => q.Id == studentUpdate.Id);
            if (student != null)
            {
                student.Name = studentUpdate.Name;
                student.Gender = studentUpdate.Gender;
                student.Address = studentUpdate.Address;
                student.MaritalStatus = studentUpdate.MaritalStatus;
                student.Nationality = studentUpdate.Nationality;
                student.DateOfBirth = studentUpdate.DateOfBirth;
                student.AddmissionType = studentUpdate.AddmissionType;
                student.BVN = studentUpdate.BVN;
                student.Phone = studentUpdate.Phone;
                student.Photo = studentUpdate.Photo;
                student.NextOfKinName = studentUpdate.NextOfKinName;
                student.NextOfKinPhone = studentUpdate.NextOfKinPhone;
                student.NextOfKinEmail = studentUpdate.NextOfKinEmail;
                student.NextOfKinDocumentUrl = studentUpdate.NextOfKinDocumentUrl;
            }
            return student;
        }
    }
}
