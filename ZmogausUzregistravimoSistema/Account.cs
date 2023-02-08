﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZmogausUzregistravimoSistema
{
    public class Account
    {
        [Key]
        public string Id { get; set; } //pk
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }
        [ForeignKey("PersonalInformationId")]
        public int PersonalInformationId { get; set; }
        public PersonalInformation PersonalInformation { get; set; }

    }
}
