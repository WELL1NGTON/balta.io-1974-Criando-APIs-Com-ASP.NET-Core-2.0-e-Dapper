using System;
using System.Globalization;
using FluentValidator;
using FluentValidator.Validation;

namespace BaltaStore.Domain.StoreContext.ValueObjects
{
    public class Document : Notifiable
    {
        public Document(string number)
        {
            Number = number;

            AddNotifications(
                new ValidationContract()
                    .IsTrue(Validate(number), "Document", "CPF inválido")
            );
        }
        public string Number { get; private set; }

        public override string ToString()
        {
            return Number;
        }

        public static bool Validate(string cpf)
        {
            if (cpf == null)
                return false;

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "", StringComparison.Ordinal).Replace("-", "", StringComparison.Ordinal);
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            // ! https://docs.microsoft.com/en-us/dotnet/standard/base-types/string-comparison-net-5-plus
            // CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            bool teste = "teste".EndsWith("te", StringComparison.Ordinal);

            return cpf.EndsWith(digito, StringComparison.Ordinal);
            // return cpf.Substring(cpf.Length - 2) == digito;
        }
    }
}