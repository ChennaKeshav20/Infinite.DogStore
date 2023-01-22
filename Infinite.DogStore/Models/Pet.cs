using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Infinite.DogStore.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "please enter pet name")]
        public string PetName { get; set; }
        [Required]
        public string Description { get; set; }


        [Required]
        public string Height { get; set; }
        [Required]
        public string Weight { get; set; }
        [Required]
        public string Age { get; set; }
        public DogBreed DogBreed { get; set; }
        public int DogBreedId { get; set; }
    }
}