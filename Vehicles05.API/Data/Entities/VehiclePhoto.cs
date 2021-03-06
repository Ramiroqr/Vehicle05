using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles05.API.Data.Entities
{
    public class VehiclePhoto
    {
        public int Id { get; set; }

        [Display(Name = "Vehiculo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public Vehicle Vehicle { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        //TODO: fix the correct path
        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44396/image/no-image.png"
            : $"https://vehicleszulu.blob.core.windows.net/vehicles/{ImageId}";


    }
}