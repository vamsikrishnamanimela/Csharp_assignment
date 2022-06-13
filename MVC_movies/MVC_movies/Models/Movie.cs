using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_movies.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Movie_Id { get; set; }
        public string Movie_Name { get; set; }
        public Nullable<System.DateTime> Release_Date { get; set; }
    }
}
