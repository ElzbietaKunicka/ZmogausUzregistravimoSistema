﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZmogausUzregistravimoSistema
{
    public class PersonalInformation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Surname { get; set; }
        public int PersonalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ResidentialAddress ResidentialAddress { get; set; }
        [ForeignKey("ResidentialAddressId")]
        public int ResidentialAddressId { get; set; }





    }
}
