using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfChat.Common
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(15)]
        public string Nombre { get; set; }
        [StringLength(20)]
        public string Contraseña { get; set; }
    }
}
