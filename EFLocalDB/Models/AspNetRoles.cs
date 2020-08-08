using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFLocalDB.Models
{
    class AspNetRoles
    {
        [Key]
        public String Id { get; set; }
        public String Name { get; set; }
    } 
}
