﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjProgramasCursoTecnico
{
    class Produto
    {
        private int codigo;
        private String nome;
        private double preco;

        public void alterarPreco(double valor) 
        { 
        }

        public String getNome() 
        {
            return this.nome;
        }

        public void setNome(String nome) 
        {
            this.nome = nome;
        }

        public int getCodigo()
        {
            return this.codigo;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public double getPreco()
        {
            return this.preco;
        }
    }
}
