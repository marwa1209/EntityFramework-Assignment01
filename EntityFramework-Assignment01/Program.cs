using EntityFramework_Assignment01.Context;
using EntityFramework_Assignment01.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ITIDbContext iTIDbContext = new ITIDbContext();
            //iTIDbContext.Database.Migrate();
            #region Assignment02 CrudOperations
            #region Create
            //using ITIDbContext Context = new ITIDbContext();
            //Student student = new Student()
            //{
            //    FName = "John",
            //    LName = "Doe",
            //    Address = "123 Main St",
            //    Age = 22,
            //};

            //Course course = new Course()
            //{
            //    Name = "Math",
            //    Description = "Algebra and Calculus",
            //    Duration = 3,
            //};

            //Instructor instructor = new Instructor()
            //{
            //    Name = "Jane Smith",
            //    Bonus = 5000,
            //    Salary = 60000,
            //    Address = "456 Elm St",
            //    HourRate = 50,
            //};

            //Department department = new Department()
            //{
            //    Name = "Mathematics",
            //    Ins_ID = instructor.ID,
            //    HiringDate = DateTime.Now,

            //};

            //Topic topic = new Topic()
            //{
            //    Name = "Algebra"
            //};

            //Stud_Course studCourse = new Stud_Course()
            //{
            //    Stud_ID = student.ID,
            //    Course_ID = course.ID,
            //    Grade = 95
            //};

            //Course_Inst courseInst = new Course_Inst()
            //{
            //    Inst_ID = instructor.ID,
            //    Course_ID = course.ID,
            //    Evaluate = "Excellent"
            //};
            // Context.Students.Add(student);
            // Context.Instructors.Add(instructor);
            //Context.Departments.Add(department);
            //Context.Topics.Add(topic);
            //Context.Courses.Add(course);
            //Context.Stud_Courses.Add(studCourse);
            // Context.Course_Insts.Add(courseInst);
            //Context.SaveChanges();
            #endregion
            #region Read
            using (var context = new ITIDbContext())
            {

                var students = context.Students.ToList();

                var courses = context.Courses.ToList();

                var instructors = context.Instructors.ToList();

                var departments = context.Departments.ToList();

                var topics = context.Topics.ToList();

                var studCourses = context.Stud_Courses.ToList();

                var courseInstructors = context.Course_Insts.ToList();
            } 
            #endregion
            #region Update
            using (var context = new ITIDbContext())
            {
                // Update a Student
                var student = context.Students.FirstOrDefault(s => s.ID == 1);
                if (student != null)
                {
                    student.Age = 23;
                    context.SaveChanges();
                }

                // Update a Course
                var course = context.Courses.FirstOrDefault(c => c.ID == 1);
                if (course != null)
                {
                    course.Description = "Advanced Algebra and Calculus";
                    context.SaveChanges();
                }

                // Update an Instructor
                var instructor = context.Instructors.FirstOrDefault(i => i.ID == 1);
                if (instructor != null)
                {
                    instructor.Salary = 65000;
                    context.SaveChanges();
                }

                // Update a Department
                var department = context.Departments.FirstOrDefault(d => d.ID == 1);
                if (department != null)
                {
                    department.Name = "Advanced Mathematics";
                    context.SaveChanges();
                }

                // Update a Topic
                var topic = context.Topics.FirstOrDefault(t => t.ID == 1);
                if (topic != null)
                {
                    topic.Name = "Calculus";
                    context.SaveChanges();
                }

                // Update a Stud_Course
                var studCourse = context.Stud_Courses.FirstOrDefault(sc => sc.Stud_ID == 1 && sc.Course_ID == 1);
                if (studCourse != null)
                {
                    studCourse.Grade = 98;
                    context.SaveChanges();
                }

                // Update a Course_Inst
                var courseInst = context.Course_Insts.FirstOrDefault(ci => ci.Inst_ID == 1 && ci.Course_ID == 1);
                if (courseInst != null)
                {
                    courseInst.Evaluate = "Outstanding";
                    context.SaveChanges();
                }
            }

            #endregion
            #region Delete
            using (var context = new ITIDbContext())
            {
                // Delete a Student
                var student = context.Students.FirstOrDefault(s => s.ID == 1);
                if (student != null)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                }

                // Delete a Course
                var course = context.Courses.FirstOrDefault(c => c.ID == 1);
                if (course != null)
                {
                    context.Courses.Remove(course);
                    context.SaveChanges();
                }

                // Delete an Instructor
                var instructor = context.Instructors.FirstOrDefault(i => i.ID == 1);
                if (instructor != null)
                {
                    context.Instructors.Remove(instructor);
                    context.SaveChanges();
                }

                // Delete a Department
                var department = context.Departments.FirstOrDefault(d => d.ID == 1);
                if (department != null)
                {
                    context.Departments.Remove(department);
                    context.SaveChanges();
                }

                // Delete a Topic
                var topic = context.Topics.FirstOrDefault(t => t.ID == 1);
                if (topic != null)
                {
                    context.Topics.Remove(topic);
                    context.SaveChanges();
                }

                // Delete a Stud_Course
                var studCourse = context.Stud_Courses.FirstOrDefault(sc => sc.Stud_ID == 1 && sc.Course_ID == 1);
                if (studCourse != null)
                {
                    context.Stud_Courses.Remove(studCourse);
                    context.SaveChanges();
                }

                // Delete a Course_Inst
                var courseInst = context.Course_Insts.FirstOrDefault(ci => ci.Inst_ID == 1 && ci.Course_ID == 1);
                if (courseInst != null)
                {
                    context.Course_Insts.Remove(courseInst);
                    context.SaveChanges();
                }
            } 
            #endregion
            #endregion

        }
    }
}
