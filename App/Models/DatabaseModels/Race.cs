#nullable disable

using System.ComponentModel.DataAnnotations;

namespace App.Models.DatabaseModels;

public class Race
{
    public class Result
    {
        public int Id { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual Race Race { get; set; }
        public virtual Vehicule Vehicule { get; set; }
        public uint Position { get; set; }
    }

    public uint Id { get; set; }

    #region Race Infos
    [Required(ErrorMessage = "L'attitude' de la course est requise.")]
    [Range(0, double.MaxValue, ErrorMessage = "Veuillez entrer une latitude valide.")]
    public double Lattitude { get; set; }

    [Required(ErrorMessage = "La longitude de la course est requise.")]
    [Range(0, double.MaxValue, ErrorMessage = "Veuillez entrer une longitude valide.")]
    public double Longitude { get; set; }

    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Le nom de la course est requis.")]
    [MinLength(2, ErrorMessage = "Le nom de la course doit comporter plus de 2 caractères.")]
    [MaxLength(50, ErrorMessage = "Le nom de la course doit comporter moins de 50 caractères.")]
    public string Name { get; set; }

    [DataType(DataType.DateTime)]
    [Required(ErrorMessage = "La date et l'heure de la course sont obligatoires.")]
    [Display(Name = "Date/heure de l'événement")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm::ss}")]
    public DateTime EventDate { get; set; }

    [DataType(DataType.ImageUrl)]
    public string Image { get; set; } = string.Empty;

    public virtual List<Result> Results { get; set; }
    #endregion

    #region Race Drivers
    [Range(0, uint.MaxValue, ErrorMessage = "Enter un nombre Valide.")]
    [Display(Name = "Nombre Maximal de Participant")]
    public uint MaxParticipants { get; set; } = 15;

    [Range(0, uint.MaxValue, ErrorMessage = "Enter un nombre Valide.")]
    [Display(Name = "Age Minimum des Participants")]
    public uint MinAge { get; set; } = 21;

    public virtual List<Driver> Drivers { get; set; }
    #endregion

    #region Race Vehicules
    [Required(ErrorMessage = "Catégorie de véhicules autorisés.")]
    [Display(Name = "Catégorie de véhicules autorisés")]
    public virtual List<Vehicule.AvailableCategory> AllowedCategories { get; set; }
    #endregion
}
