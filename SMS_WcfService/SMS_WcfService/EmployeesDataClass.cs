﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_WcfService
{
    public class EmployeesDataClass
    {
        private static List<Teacher> teachers = new List<Teacher>();

        private static Teacher current_teacher; 

        private static Librarian librarian = new Librarian();

        public static void addTeacher(Teacher t)
        {
            teachers.Add(t);
        }

        public static List<Teacher> searchByCourse(string name)
        {
            return teachers;
        }

        public static void changeLibrarian(Librarian lb)
        {
            librarian = lb;
        }

        public static List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }

            set
            {
                teachers = value;
            }
        }

        public static Librarian Librarian
        {
            get
            {
                return librarian;
            }

            set
            {
                librarian = value;
            }
        }

        public static Teacher Current_teacher
        {
            get
            {
                return current_teacher;
            }

            set
            {
                current_teacher = value;
            }
        }
    }
}