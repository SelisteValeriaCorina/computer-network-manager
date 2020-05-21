using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    [Serializable]
    public class Right
    {
        [Key]
        public String RightName { get; set; }

        public Right()
        {
        }

        public Right(string rightName)
        {
            RightName = rightName;
        }

    }
}
