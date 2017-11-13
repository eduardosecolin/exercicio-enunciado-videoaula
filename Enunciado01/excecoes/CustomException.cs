using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado01.excecoes {
    class CustomException : Exception {
        private string message;
        public CustomException(string mensagem) : base(mensagem) {
            mensagem = "ERRO!!!";
            this.message = mensagem;
        }
    }
}
