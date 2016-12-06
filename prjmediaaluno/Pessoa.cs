using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjProgramasCursoTecnico
{
    class Pessoa
    {
        private string nome;
        private string endereco;
        private string telefone;

        public void pessoa() {

        }

        public void pessoa(string nome, string endereco, string telefone) {

        }

        public string getNome() {
            return this.nome;
        }

        public void setNome(string nome) {
            this.nome = nome;
        }

        public string getEndereco() {
            return this.endereco;
        }

        public void setEndereco(string endereco) {
            this.endereco = endereco;
        }

        public string getTelefone()
        {
            return this.telefone;
        }

        public void setTelefone(string telefone) {
            this.telefone = telefone;
        }

        public void inserirDadosPessoa() { }

        public void apresentarPessoa() { }

        /* E no main para chamar a classe, você cria um objeto dela, ou a instancia:
                Pessoa ps = new Pessoa();

        A partir dela você pode chamar qualquer método dentro dela a partir do objeto desta classe, exemplo:
                ps.setNome("Jorge");
        */
    }
}
