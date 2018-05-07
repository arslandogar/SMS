using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Drawing;

namespace SMS_WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void sSetDefaultAdmin();

        [OperationContract]
        void sChangeLibrarian(string name, string cnic, string gender, string email, string mobile_no, string address, string date_of_birth, string joing_date, string employee_no);

        [OperationContract]
        bool sValidAdmin(string username, string password);

        [OperationContract]
        void sAddParent(string name, string cnic, string contact, string childCnic);

        [OperationContract]
        void sAddStudent(string name, string cnic, string gender, string email, string roll_no, string date_of_birth, string contact, List<string> courseNames, string address);

        [OperationContract]
        bool sValidLibrarian(string email, string password);

        [OperationContract]
        List<Book> sViewAllBooks();

        [OperationContract]
        List<Book> sViewBookByName(string name);

        [OperationContract]
        List<Book> sViewBookByAuthor(string author);

        [OperationContract]
        void sAddBook(string title, string author);

        [OperationContract]
        bool sRemoveBook(string title);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<string> sViewBookNames();

        [OperationContract]
        bool sMarkAttendanceEmployee(string employee_no, string date, string status);

        [OperationContract]
        List<string> sViewEmployeeNumbers();

        [OperationContract]
        List<string> sViewRollNumbers();

        [OperationContract]
        List<Attendance> sViewAttendances(string id);

        [OperationContract]
        void sAddCourse(string name);

        [OperationContract]
        bool sValidParent(string cnic, string password);

        [OperationContract]
        List<string> sViewCourses();

        [OperationContract]
        bool sValidStudent(string roll_no, string password);

        [OperationContract]
        List<string> sGetStudentInformation();

        [OperationContract]
        List<string> sViewNullCourses();

        [OperationContract]
        void sAddTeacher(string name, string cnic, string gender, string email, string mobile_no, string address, string date_of_birth, string joing_date, string employee_no, List<string> courses_assigned);

        [OperationContract]
        bool sValidTeacher(string email, string password);

        [OperationContract]
        List<string> sGetTeacherInformation();

        [OperationContract]
        List<string> sViewTeacherNames();

        [OperationContract]
        void sAssignCourse(string teacher_id, string course_name);

        [OperationContract]
        void sSendMessageToTeacher(string message, string sender, string teacher_id);

        [OperationContract]
        void sSendMessageToParent(string message, string sender, string child_roll_no);

        [OperationContract]
        void sSendMessageToAdmin(string message, string sender);

        [OperationContract]
        void sSendMessageToStudent(string message, string sender, string roll_no);

        [OperationContract]
        List<string> sGetParentInformation();

        [OperationContract]
        List<Message> sGetAdminInbox();

        [OperationContract]
        List<Message> sGetTeacherInbox();

        [OperationContract]
        List<Message> sGetStudentInbox();

        [OperationContract]
        List<Message> sGetParentInbox();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
