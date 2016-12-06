using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjProgramasCursoTecnico
{
    class FolhaPagamento
    {
        private string matricula;
        private double salarioBase;
        private double gratificacaoPod;

        public string getMatricula() {
            return this.matricula;
        }

        public void setMatricula(string matricula) {
            this.matricula = matricula;
        }

        public double getSalarioBase() {
            return this.salarioBase;
        }

        public void setSalarioBase(double salarioBase) {
            this.salarioBase = salarioBase;
        }

        public double getGratificacaoPod(){
            return this.gratificacaoPod;
        }

        public void setGratificacaoPod(double gratificacaoPod) {
            this.gratificacaoPod = gratificacaoPod;
        }

        public double fornecaDesconto() {
            if (fornecaSalarioBruto() < 1000.01)
            {
                return fornecaSalarioBruto();
            }
            else if (fornecaSalarioBruto() > 1000.00 && fornecaSalarioBruto() < 1800.01)
            {
                return (fornecaSalarioBruto() - (fornecaSalarioBruto() * 0.1)) - 100.00;
            }
            else
            {
                return (fornecaSalarioBruto() - (fornecaSalarioBruto() * 0.25)) - 370.00;
            }
        }

        public double fornecaSalarioLiquido(){
            return fornecaDesconto();
        }

        public double fornecaSalarioBruto() {
            return getSalarioBase() + getGratificacaoPod();
        }
    }
}
