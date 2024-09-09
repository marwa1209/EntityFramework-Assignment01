using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Entities
{

    //Entity
    //Domain Model
    //Model
    //POCO Class [Plain Old Clr Object]
    #region By Convention
    //internal class Employee
    //{
    //    public int Id { get; set; }//public numeric property named as [Id|EmployeeId] =>PK [Identity Constraints(1,1)]
    //    public string? Name { get; set; }//refrence type =>alow null so it is not mandatory from 6 => changed to be required
    //    //to make the neame allow null i will make it nullabe with ?
    //    public decimal Salary { get; set; } //value type => not allow null required 
    //                                        //decimal(18,2)
    //    public int? Age { get; set; } //Nullable int :Allow Null [optional]
    //                                  //Int
    //} 
    #endregion
    #region Data Annotation
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //1 1 
        public int EmpId { get; set; }//public numeric property named as [Id|EmployeeId] =>PK [Identity Constraints(1,1)]
        [Required]
        [Column(TypeName ="varchar")]
        //[MaxLength(50)]
        [StringLength(50 ,MinimumLength =10)]
        public string? Name { get; set; }//refrence type =>alow null so it is not mandatory from 6 => changed to be required
        //to make the neame allow null i will make it nullabe with ?
       // [Column(TypeName ="Money")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; } //value type => not allow null required 
        [Range(22,60)]                             //decimal(18,2)
        public int? Age { get; set; } //Nullable int :Allow Null [optional]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumbert { get; set; }
        #region one to many relationship
        public Department Department { get; set; }

        //navigitional property
        #endregion
        [ForeignKey("Department")]
        public int? DepartmentDeptId { get; set; }
    }
    #endregion
}
