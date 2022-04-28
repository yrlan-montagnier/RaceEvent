#nullable disable

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace App.Models.DatabaseModels;

public class Driver : IdentityUser
{
    #region Informations personnelles du conducteur
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Le prénom est requis.")]
    [MinLength(2, ErrorMessage = "Le prénom doit faire au minimum 2 caractères.")]
    [MaxLength(30, ErrorMessage = "Le prénom doit faire au maximum 30 caractères.")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Le nom de famille est requis.")]
    [MinLength(2, ErrorMessage = "Le nom de famille doit comporter plus de 2 caractères.")]
    [MaxLength(30, ErrorMessage = "Le nom de famille doit comporter moins de 30 caractères.")]
    [Display(Name = "Nom de famille")]
    public string LastName { get; set; }

    [DataType(DataType.Date)]
    [Required(ErrorMessage = "La date de naissance est requise.")]
    [Display(Name = "Date de naissance")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime BirthDate { get; set; }

    #endregion

    #region Informations sur la course des pilotes
    public virtual List<Vehicule> Vehicules { get; set; }
    public virtual List<Race> Races { get; set; }
    #endregion
}
