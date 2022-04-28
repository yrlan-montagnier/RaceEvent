#nullable disable

using System.ComponentModel.DataAnnotations;

namespace App.Models.DatabaseModels;

public class Vehicule
{
    public class AvailableCategory
    {
        public uint Id { get; set; }

        #region Category Infos
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Le nom est requis")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "La couleur est requise")]
        public string Color { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }
        #endregion
    }

    public uint Id { get; set; }

    #region Vehicule Infos
    [DataType(DataType.Date)]
    [Display(Name = "Date de construction")]
    public DateTime BuildDate { get; set; }

    [DataType(DataType.Text)]
    [Required(ErrorMessage = "La marque est requise.")]
    public string Brand { get; set; }

    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Le modèle est requis.")]
    public string Model { get; set; }

    [DataType(DataType.ImageUrl)]
    public string Image { get; set; }

    [Required(ErrorMessage = "Le niveau de puissance est requis.")]
    [Range(0, uint.MaxValue, ErrorMessage = "S'il vous plait, entrez un nombre valide.")]
    public uint PowerLevel { get; set; }

    [Required(ErrorMessage = "La puissance est requise.")]
    [Range(0, uint.MaxValue, ErrorMessage = "S'il vous plait, entrez un nombre valide.")]
    public uint HorsePower { get; set; }
    #endregion

    public virtual List<AvailableCategory> Categories { get; set; }
    public virtual List<Driver> PossessedBy { get; set; }
}
