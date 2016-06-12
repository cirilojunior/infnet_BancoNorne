using Domain.Produtos;
using Domain.Usuarios;
using Domain.Usuarios.Contatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class ContaBinding
    {

        public ContaBinding()
        {
        }

        public ContaBinding(Conta conta)
        {
            
            this.Tipo = getTipoConta(conta.Tipo);
            this.SituacaoCriacao = getSituacaoCriacao(conta.SituacaoCriacao);
            this.Situacao = getSituacao(conta.Situacao);
            this.Cliente = conta.Cliente;
            this.Saldo = conta.Saldo;
            this.codigoConta = conta.codigoConta;
            PessoaFisica pf = (PessoaFisica)conta.Cliente.Pessoa;
            this.Nome = pf.Nome;
            this.Cpf = pf.Cpf;

            this.Identidade = pf.Identidade;
            this.rendaMensal = pf.rendaMensal;
            this.TelefonePrincipal = pf.Contato.TelefonePrincipal;
            this.TelefoneAlternativo = pf.Contato.TelefoneAlternativo;
            this.Email = pf.Contato.Email;
            this.Logradouro = pf.Endereco.Logradouro;
            this.Numero = pf.Endereco.Numero;
            this.Complemento = pf.Endereco.Complemento;
            this.Cep = pf.Endereco.Cep;
            this.Cidade = pf.Endereco.Cidade;

        }

        private SituacaoConta getSituacao(Conta.SituacaoConta situacao)
        {
            if (situacao == Conta.SituacaoConta.VIGENTE)
            {
                return SituacaoConta.VIGENTE;
            }
            else
            {
                return SituacaoConta.ENCERRADA;
            }
        }

        private SituacaoCriacaoConta getSituacaoCriacao(Conta.SituacaoCriacaoConta situacaoCriacao)
        {
            if (situacaoCriacao == Conta.SituacaoCriacaoConta.APROVADA)
            {
                return SituacaoCriacaoConta.APROVADA;
            }
            else if(situacaoCriacao == Conta.SituacaoCriacaoConta.PENDENTE_APROVACAO)
            {
                return SituacaoCriacaoConta.PENDENTE_APROVACAO;
            }else
            {
                return SituacaoCriacaoConta.REPROVADA;
            }
        }

        private TipoConta getTipoConta(Conta.TipoConta tipo)
        {
            if (tipo == Conta.TipoConta.POUPANCA)
            {
                return TipoConta.POUPANCA;
            }
            else if (tipo == Conta.TipoConta.CORRENTE)
            {
                return TipoConta.CORRENTE;
            }
            else if (tipo == Conta.TipoConta.ELETRONICA)
            {
                return TipoConta.ELETRONICA;
            }
            else if (tipo == Conta.TipoConta.SALARIO)
            {
                return TipoConta.SALARIO;
            }
            else
            {
                return TipoConta.ESPECIAL_ELETRONICA;
            }
        }

        public enum TipoConta
        {
            POUPANCA, CORRENTE, ELETRONICA, SALARIO, ESPECIAL_ELETRONICA
        }

        public enum SituacaoCriacaoConta
        {
            PENDENTE_APROVACAO, APROVADA, REPROVADA
        }

        public enum SituacaoConta
        {
            VIGENTE, ENCERRADA
        }


        public TipoConta Tipo { get; set; }
        public SituacaoCriacaoConta SituacaoCriacao { get; set; }
        public SituacaoConta Situacao { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Saldo { get; set; }
        public String codigoConta { get; set; }
        public String cnpjFontePagadora { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Identidade { get; set; }
        public double rendaMensal { get; set; }
        public double LimiteChequeEspecial { get; set; }

        //contato
        public string TelefonePrincipal { get; set; }
        public string TelefoneAlternativo { get; set; }
        public string Email { get; set; }

        //endereco
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }

        public Conta toConta()
        {
            Conta conta = new Conta();
            if (this.Tipo == TipoConta.POUPANCA)
            {
                conta.Tipo = Conta.TipoConta.POUPANCA;
            }
            else if (this.Tipo == TipoConta.CORRENTE)
            {
                conta.Tipo = Conta.TipoConta.CORRENTE;
            }
            else if (this.Tipo == TipoConta.ELETRONICA)
            {
                conta.Tipo = Conta.TipoConta.ELETRONICA;
            }
            else if (this.Tipo == TipoConta.SALARIO)
            {
                conta.Tipo = Conta.TipoConta.SALARIO;
            }
            else if (this.Tipo == TipoConta.ESPECIAL_ELETRONICA)
            {
                conta.Tipo = Conta.TipoConta.ESPECIAL_ELETRONICA;
            }

            return conta;
        }

        internal PessoaFisica toPessoa()
        {
            PessoaFisica pessoa = new PessoaFisica();
            pessoa.Nome = this.Nome;
            pessoa.Cpf = this.Cpf;
            pessoa.rendaMensal = this.rendaMensal;
            pessoa.Identidade = this.Identidade;

            Contato contato = new Contato();
            contato.TelefonePrincipal = this.TelefonePrincipal;
            contato.TelefoneAlternativo = this.TelefoneAlternativo;
            contato.Email = this.Email;
            pessoa.Contato = contato;

            Endereco endereco = new Endereco();
            endereco.Logradouro = this.Logradouro;
            endereco.Numero = this.Numero;
            endereco.Complemento = this.Complemento;
            endereco.Cep = this.Cep;
            endereco.Cidade = this.Cidade;
            endereco.Estado = Endereco.UF.RJ;
            pessoa.Endereco = endereco;

            return pessoa;
        }
    }
}