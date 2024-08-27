using NetDevPack.Domain;

namespace MySolution.Commons.valueobjects;

public class Cpf : ValueObject
{
    public string Numero { get; private set; }

        public Cpf(string numero)
        {
            if (!IsValid(numero))
                throw new ArgumentException("CPF inválido");

            Numero = FormatCpf(numero);
        }

        // Método para validar o CPF
        public static bool IsValid(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                return false;

            // Evitar CPFs inválidos conhecidos
            var invalidos = new string[]
            {
                "00000000000", "11111111111", "22222222222", 
                "33333333333", "44444444444", "55555555555", 
                "66666666666", "77777777777", "88888888888", 
                "99999999999"
            };

            if (invalidos.Contains(cpf))
                return false;

            // Validação do primeiro dígito verificador
            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = tempCpf.Select((t, i) => int.Parse(t.ToString()) * multiplicadores1[i]).Sum();
            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf += digito;

            // Validação do segundo dígito verificador
            soma = tempCpf.Select((t, i) => int.Parse(t.ToString()) * multiplicadores2[i]).Sum();
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

        // Método para formatar o CPF com pontos e traço
        private string FormatCpf(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        public override string ToString()
        {
            return Numero;
        }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}
