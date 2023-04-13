using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace projeto_introducao_asp.Models
{
    public class Usuario 
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma informação de 5 a 10 caracteres")]
        public string Observacoes {get; set; }
        [Range(18, 70, ErrorMessage = "A idade tem que está entre 18 e 70 anos!")]
        public int Idade {get; set;}
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um e-mail válido")]
        public string Email {get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente Letras de 5 a 15 caracteres")]
        [Required(ErrorMessage =  "O login é obrigatório")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Esse login ja existe")]
        public string Login { get; set; }

        [Required(ErrorMessage =  "A senha é obrigatória")]
        public string Senha {get; set; }
        [Compare("Senha", ErrorMessage = "As senhas não se coincidem")]
        public string ConfirmarSenha {get; set; }
    }
}