namespace HerancaPOO.classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;
        

        public string ValidarCPF(string documento){
            if(documento != ""){
                return "CPF válido";   
            }

            return "CPF inválido";
        }
    }
}