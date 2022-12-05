using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DummyBazaarOzi.Models
{
    public class Manager
    {
        public int ID { get; set; }
       
        public int manager_typeID { get; set; }
        [ForeignKey("manager_typeID")]
        public virtual ManagerType ManagerType { get; set; }

        [Required(ErrorMessage="Bu alan zorunludur")]
        [StringLength(maximumLength:50, ErrorMessage = "En fazla 50 karakter")]
        public string Name { get; set; }

        [StringLength(maximumLength: 50, ErrorMessage = "En fazla 50 karakter")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "En fazla 50 karakter")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 20, ErrorMessage = "Şifre en az 8 ile en fazla 20 karakter arasında olmalıdır")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "En fazla 250 karakter")]
        public string Mail { get; set; }

        public bool IsActive { get; set; }

    }
}