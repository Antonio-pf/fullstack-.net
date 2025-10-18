using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class CreateTransactionRequest : Request
{
    [Required(ErrorMessage = "Título inválido")]
    [MaxLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
    public string Title { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Descrição inválida")]
    public string Description { get; set; } = String.Empty;

}