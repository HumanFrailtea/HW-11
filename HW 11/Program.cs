/// Homework No.__ Exercise No.__
/// File Name:     HW11.sln
/// @author:       Upendra Samaranayake
/// Date:          Nov. 23, 2020
///
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Read();
            var students = new Student[] {
        new Student() {
          FirstName = "Philip", LastName = "Rivers", Grade = 91
        }, new Student() {
          FirstName = "Tom", LastName = "Brady", Grade = 49
        }, new Student() {
          FirstName = "Sam", LastName = "Darnold", Grade = 92
        }, new Student() {
          FirstName = "Pete", LastName = "Carroll", Grade = 87
        }, new Student() {
          FirstName = "Deion", LastName = "Sanders",  Grade = 77
        }, new Student() {
          FirstName = "Joe", LastName = "Montana", Grade = 99
        }
      };
            Array.Sort(students);            
            foreach (var student in students)             {                 
                Console.WriteLine(student.ToString());             }             
            Console.WriteLine("********************************");         
        }
        }
    }

        public class Student : IComparable
        {
            private string m_FirstName = string.Empty;
            private string m_LastName = string.Empty;
            private int m_Grade;
            public Student() { }
            public Student(string firstName, string lastName, string degree, int grade)
            {
                m_FirstName = firstName;
                m_LastName = lastName;
                m_Grade = grade;
            }
            public string FirstName
            {
                get
                {
                    return m_FirstName;
                }
                set
                {
                    m_FirstName = value;
                }
            }
            public string LastName
            {
                get
                {
                    return m_LastName;
                }
                set
                {
                    m_LastName = value;
                }
            }
            public int Grade
            {
                get
                {
                    return m_Grade;
                }
                set
                {
                    m_Grade = value;
                }
            }
            public int CompareTo(Object other) {           
                if (String.Compare(this.FirstName, ((Student)other).FirstName) == 0 &&              
                    String.Compare(this.LastName, ((Student)other).LastName) == 0               
                    && this.Grade == ((Student)other).Grade)             
                {                 
                    return 1;             
                }            
                if (
                    this.Grade > ((Student)other).Grade)            
                {                 return 1;
              }             return -1;                     }         
            
            public override string ToString()         {             
                return $"Last Name {this.LastName}, " +
                    $"First Name {this.FirstName} , Grade {this.Grade.ToString()}";        
            }     
} 