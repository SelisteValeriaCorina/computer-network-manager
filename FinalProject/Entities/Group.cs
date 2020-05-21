using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    [Serializable]
    public class Group
    {
        [Key]
        public String Name { get; set; }
        public String AgeRestricted { get; set; }
        public String Description { get; set; }
        public Right right { get; set; }
        public Group()
        {

        }

        //constructor with fields
        public Group(string name, String ageRestricted, string description)
        {
            Name = name;
            AgeRestricted = ageRestricted;
            Description = description;
            this.right = new Right();

        }

        // constructor with all fields
        public Group(string name, String ageRestricted, string description,string NameRight)
        {
            Name = name;
            AgeRestricted = ageRestricted;
            Description = description;
            this.right = new Right(NameRight);
        }


        public Group(string name, String ageRestricted, string description,Right r)
        {
            Name = name;
            AgeRestricted = ageRestricted;
            Description = description;
            this.right =r;

           // this.right = new Right(r); va da eroare, de ce nu merge?
        }


    }
}
