using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book1.Model
{
    public class Book
    {
        [Key]
        public int BkType_Id { get; set; }
        public String BkType_Description { get; set; }
    }
}
