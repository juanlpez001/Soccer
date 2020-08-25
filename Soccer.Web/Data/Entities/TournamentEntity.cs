using System;
using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Data.Entities
{
    public class TournamentEntity
    {
        public int Id { get; set; }


        //Name tournament


        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }



        //Start date tournament

        [DataType(DataType.DateTime)]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime StartDate { get; set; }






        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime StartDateLocal => StartDate.ToLocalTime();




        //Tournament end date


        [DataType(DataType.DateTime)]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime EndDate { get; set; }





        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime EndDateLocal => EndDate.ToLocalTime();




        //tournament active or not

        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; }





        //Logo tournament

        [Display(Name = "Logo")]
        public string LogoPath { get; set; }
    }
}
