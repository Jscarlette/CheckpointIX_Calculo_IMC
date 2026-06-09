using System.ComponentModel.DataAnnotations;

namespace CheckpointIX_Calculo_IMC.Models;

public class ImcViewModel
{
    [Required(ErrorMessage = "Peso é obrigatório.")]
    [Range(1, 500, ErrorMessage = "Informe um peso entre 1 e 500 kg.")]
    [Display(Name = "Peso (kg)")]
    public double? Peso { get; set; }

    [Required(ErrorMessage = "Altura é obrigatória.")]
    [Range(0.5, 3.0, ErrorMessage = "Informe uma altura entre 0,50 e 3,00 metros.")]
    [Display(Name = "Altura (m)")]
    public double? Altura { get; set; }

    [Display(Name = "IMC")]
    public double? Imc { get; set; }

    [Display(Name = "Classificação")]
    public string? Classificacao { get; set; }
}
