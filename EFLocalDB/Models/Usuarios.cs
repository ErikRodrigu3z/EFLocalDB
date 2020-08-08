using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFLocalDB.Models
{
    class Usuarios
    {
        [Key]
        public int id_usuario { get; set; }
        public String nombre { get; set; }
        public String password { get; set; }
      
    }
}
