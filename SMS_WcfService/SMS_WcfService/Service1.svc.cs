using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SMS_WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void sAddBook(string title, string author)
        {
            Book temp = new Book();
            temp.Title = title;
            temp.Author = author;
            BooksDataClass.addBook(temp);
        }

        public void sAddCourse(string name)
        {
            Course temp = new Course();
            temp.Title = name;
            CoursesDataClass.addCourse(temp);
        }

        public void sAddParent(string name, string cnic, string contact, string childCnic)
        {
            Parent parent = new Parent();
            parent.Name = name;
            parent.Mobile_no = contact;
            parent.Cnic = cnic;
            foreach(Student s in StudentsDataClass.Students)
            {
                if(s.Cnic == childCnic)
                {
                    parent.Child = s;
                    s.Parent = parent;
                }
            }
        }

        public void sAddStudent(string name, string cnic, string gender, string email, string roll_no, string date_of_birth, string contact, List<string> courseNames, string address)
        {
            Student student = new Student();
            student.Name = name;
            student.Cnic = cnic;
            student.Gender = gender;
            student.Email = email;
            student.Roll_no = roll_no;
            student.Date_of_birth = date_of_birth;
            student.Mobile_no = contact;
            student.Address = address;
            foreach(string courName in courseNames)
            {
                foreach(Course c in CoursesDataClass.Courses)
                {
                    if(courName == c.Title)
                    {
                        student.addCourse(c);
                    }
                }
            }
            StudentsDataClass.addStudent(student);
        }

        public void sChangeLibrarian(string name, string cnic, string gender, string email, string mobile_no, string address, string date_of_birth, string joing_date, string employee_no)
        {
            Librarian librarian = new Librarian();
            librarian.Name = name;
            librarian.Cnic = cnic;
            librarian.Gender = gender;
            librarian.Email = email;
            librarian.Mobile_no = mobile_no;
            librarian.Address = address;
            librarian.Date_of_birth = date_of_birth;
            librarian.Joining_date = joing_date;
            librarian.Employee_no = employee_no;
            EmployeesDataClass.changeLibrarian(librarian);
        }

        public List<string> sGetStudentInformation()
        {
            List<string> temp = new List<string>();
            temp.Add(StudentsDataClass.Current_student.Name);
            temp.Add(StudentsDataClass.Current_student.Gender);
            temp.Add(StudentsDataClass.Current_student.Parent.Name);
            temp.Add(StudentsDataClass.Current_student.Date_of_birth);
            temp.Add(StudentsDataClass.Current_student.Roll_no);
            temp.Add(StudentsDataClass.Current_student.Email);
            temp.Add(StudentsDataClass.Current_student.Mobile_no);
            temp.Add(StudentsDataClass.Current_student.Address);
            return temp;
        }

        public bool sMarkAttendanceEmployee(string employee_no, string date, string status)
        {
            Attendance attendance = new Attendance();
            attendance.Date = date;
            if(EmployeesDataClass.Librarian.Employee_no == employee_no)
            {
                attendance.Status = status;
                EmployeesDataClass.Librarian.addAttendance(attendance);
                return true;
            }
            foreach(Teacher t in EmployeesDataClass.Teachers)
            {
                if(t.Employee_no == employee_no)
                {
                    attendance.Status = status;
                    t.addAttendance(attendance);
                    return true;
                }
            }
            return false;
        }

        public bool sRemoveBook(string title)
        {
            foreach(Book b in BooksDataClass.Books)
            {
                if(b.Title == title)
                {
                    BooksDataClass.Books.Remove(b);
                    return true; ;
                }
            }
            return false;
        }

        public void sSetDefaultAdmin()
        {
            if(AdminDataClass.adminSet)
            {
                return;
            } else
            {
                AdminDataClass.setDefaultAdmin();
                AdminDataClass.adminSet = true;
            }
        }

        public bool sValidAdmin(string username, string password)
        {
            if(AdminDataClass.admin.Username == username && AdminDataClass.admin.Password == password)
            {
                return true;
            }
            return false;
        }

        public bool sValidLibrarian(string email, string password)
        {
            if (EmployeesDataClass.Librarian.Email == email && EmployeesDataClass.Librarian.Password == password)
            {
                return true;
            }
            return false;
        }

        public bool sValidParent(string cnic, string password)
        {
            if (StudentsDataClass.Students != null)
            {
                foreach (Student s in StudentsDataClass.Students)
                {
                    if (s.Parent.Cnic == cnic && s.Parent.Password == password)
                    {
                        StudentsDataClass.Current_parent = s.Parent;
                        return true;
                    }
                }
            }
            return false;
        }

        public List<Book> sViewAllBooks()
        {
            return BooksDataClass.Books;
        }

        public List<Attendance> sViewAttendances(string id)
        {
            List<Attendance> temp = new List<Attendance>(); 
            if(EmployeesDataClass.Librarian.Employee_no == id)
            {
                return EmployeesDataClass.Librarian.Attendances;
            }
            foreach(Teacher t in EmployeesDataClass.Teachers)
            {
                if(t.Employee_no == id)
                {
                    return t.Attendances;
                }
            }
            foreach(Student s in StudentsDataClass.Students)
            {
                if(s.Roll_no == id)
                {
                    return s.Attendances;
                }
            }
            return temp;
        }

        public List<Book> sViewBookByAuthor(string author)
        {
            return BooksDataClass.searchByAuthor(author);
        }

        public List<Book> sViewBookByName(string name)
        {
            return BooksDataClass.searchByName(name);
        }

        public List<string> sViewBookNames()
        {
            List<string> temp = new List<string>();
            foreach(Book b in BooksDataClass.Books)
            {
                temp.Add(b.Title);
            }
            return temp;
        }

        public List<string> sViewCourses()
        {
            List<string> temp = new List<string>();
            foreach(Course c in  CoursesDataClass.Courses)
            {
                temp.Add(c.Title);
            }
            return temp;
        }

        public List<string> sViewEmployeeNumbers()
        {
            List<string> temp = new List<string>();
            temp.Add(EmployeesDataClass.Librarian.Employee_no);
            foreach(Teacher t in EmployeesDataClass.Teachers)
            {
                temp.Add(t.Employee_no);
            }
            return temp;
        }

        public List<string> sViewRollNumbers()
        {
            List<string> temp = new List<string>();
            foreach(Student s in StudentsDataClass.Students)
            {
                temp.Add(s.Roll_no);
            }
            return temp;
        }

        public bool sValidStudent(string roll_no, string password)
        {
            foreach(Student s in StudentsDataClass.Students)
            {
                if(s.Roll_no == roll_no && s.Password == password)
                {
                    StudentsDataClass.Current_student = s;
                    return true;
                }
            }
            return false;
        }
    }
}
