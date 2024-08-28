using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionCarros.Models;

[Table("carros")]
public class Carro
{
    [Key]
    [Column("id")]
    public required Guid Id { get; set; } = Guid.NewGuid();

    [Column("marca")]
    [MaxLength(45, ErrorMessage = "El campo ~Marca~ está incorrecto.")]
    public required string Marca { get; set; }

    [Column("modelo")]
    [MaxLength(45, ErrorMessage = "El campo ~Modelo~ está incorrecto.")]     
    public required string Modelo { get; set; }

    [Column("año")]
    [MaxLength(11, ErrorMessage = "El campo ~Año~ está incorrecto.")]
    public required int Año { get; set; }

    [Column("color")]
    [MaxLength(45, ErrorMessage = "El campo ~color~ está incorrecto.")]
    public required string Color { get; set; }               

    [Column("numero_chasis")]
    [MaxLength(45, ErrorMessage = "El campo ~Numero De Chasis~ está incorrecto.")]
    public required string NumeroDeChasis { get; set; }

    [Column("motor")]
    [MaxLength(45, ErrorMessage = "El campo ~motor~ está incorrecto.")]
    public required string Motor { get; set; }

    [Column("kilometraje")]
    [MaxLength(45, ErrorMessage = "El campo ~kilometraje~ está incorrecto.")]
    public required int Kilometraje { get; set; }

    [Column("precio")]
    [MinLength(2, ErrorMessage = "El campo ~Precio~ está incorrecto.")]
    [MaxLength(10, ErrorMessage = "El campo ~Precio~ está incorrecto.")]
    public required decimal Precio { get; set; }           
    
    [Column("combustible")]
    [MaxLength(45, ErrorMessage = "El campo ~Combustible~ está incorrecto.")]  
    public required string Combustible { get; set; }

    [Column("fecha_registro")]
    public required  DateOnly FechaDeRegistro { get; set; }
}