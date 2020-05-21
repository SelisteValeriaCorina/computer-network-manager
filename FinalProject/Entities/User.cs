using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    [Serializable]
    [Table(name:"utilizatori")]
    public class User
    {
        [Key]
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public int Age { get; set; }
        public Group group { get; set; }

        public User()
        {
            LastName = "unknown";
            FirstName = "unknown";
            Age = 0;
            group = null;
       }

        public User(string lastName, string firstName, int age,Group group)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            this.group = group;
        }

        public User(string lastName, string firstName, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;

            this.group = new Group();
        }

        public User(string lastName, string firstName, int age, String groupName,String groupDescription,String restriction)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            this.group = new Group(groupName,groupDescription,restriction);
        }
    }
}
