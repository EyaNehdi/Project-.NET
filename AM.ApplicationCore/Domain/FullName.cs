using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AM.ApplicationCore.Domain
{
    // entité associé
    //[Owned]
    public class FullName
    {
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Name should be between 3 and 25 characters.")]
        public String FirstName { get; set; }
        //public int Id { get; set; }
        public String LastName { get; set; }
    }
}
