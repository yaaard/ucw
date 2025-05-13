namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Required]
        public string surname { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string middle_name { get; set; }

        [Required]
        public string e_mail { get; set; }

        [Required]
        public string login { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public string telephone_number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
