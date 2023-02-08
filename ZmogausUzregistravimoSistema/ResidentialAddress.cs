using System.ComponentModel.DataAnnotations;

namespace ZmogausUzregistravimoSistema
{
    public class ResidentialAddress
    {
        [Key]   
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HomeNumber { get; set; }
        public int ApartmentNumber { get; set; }
    }
}
