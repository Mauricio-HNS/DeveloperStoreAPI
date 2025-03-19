using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.Domain.Entities
{
    public class Branch
    {
        // Propriedades básicas de uma filial
        public int BranchId { get; set; }  // ID único para a filial
        public string Name { get; set; }   // Nome da filial
        public string Address { get; set; } // Endereço da filial
        public string PhoneNumber { get; set; } // Número de telefone
        public string Email { get; set; }  // E-mail da filial

        // Caso queira adicionar lógica de negócios, métodos ou validações, pode fazer aqui.
    }
}

