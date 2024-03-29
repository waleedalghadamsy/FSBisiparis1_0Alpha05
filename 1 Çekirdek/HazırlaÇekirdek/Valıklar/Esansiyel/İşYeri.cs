using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HazırlaÇekirdek.Valıklar.Esansiyel
{
    public class İşyeri : TemelVarlık, IEquatable<İşyeri>
    {
        #region Data Members
        //protected string name; 
        //protected LocationAddress locationAddress;
        //protected Communication contactDetails;
        //protected List<ContactPerson> contactPersons;
        #endregion

        #region Constructors
        public İşyeri()
        {
        }

        public İşyeri(string isim)
        {
            İsim = isim;
            //İletişim = new İşyeriİletişim();
        }
        #endregion

        #region Properties
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        [Required, StringLength(50)]
        public string İsim { get; set; }
        //public CommercialActivity Activity { get; set; }
        [NotMapped]
        public İşyeriİletişim İletişim { get; set; }
        [Required]
        public bool ÖzelSektörMü { get; set; }
        [StringLength(34)]
        public string BankaHesabıIban { get; set; }
        [StringLength(100)]
        public string BankaHesabıSahibi { get; set; }
        //[ForeignKey("İletişim")]
        public int İletişimId { get; set; }
        #endregion

        #region Methods
        //public void Method()
        //{
        //}
        #endregion

        #region IEquatable<Company> Members

        public bool Equals(İşyeri diğer)
        {
            if (!string.IsNullOrWhiteSpace(İsim))
                return string.Compare(İsim, diğer.İsim, true) == 0;
            else
                return false;
        }

        #endregion
    }
}
