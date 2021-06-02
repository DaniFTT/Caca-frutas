using System;
using System.Security.Cryptography;
using System.Text;


namespace Caça_frutas
{
    public static class PasswordHandler
    {

        /// <summary>
        /// Cria uma senha encriptografada para o jogador
        /// </summary>
        /// <param name="text">Senha digitada pelo Jogador a criar a conta</param>
        /// <returns></returns>
        public static string HashSenha(string text)
        {
            if (!(string.IsNullOrEmpty(text)))
            {
                // Calcular o Hash
                MD5 md5 = MD5.Create();
                byte[] inputBytes = Encoding.ASCII.GetBytes(text);
                byte[] hash = md5.ComputeHash(inputBytes);

                // Converter byte array para string hexadecimal
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
            else
            {
                throw new Exception("A senha é obrigatoria");
            }

        }

        /// <summary>
        /// Verifica se a senha digitada pelo jogador no login está correta(true) ou não(false)
        /// </summary>
        /// <param name="senhaUsada">Senha utilizada no login</param>
        /// <param name="senhaUsuario">Senha do usuário correspondente</param>
        /// <returns>Retorna um booleano caso a senha esteja correta(true) ou não(false)</returns>
        public static bool ComparaSenha(string senhaUsada, string senhaUsuario)
        {
            string senha = HashSenha(senhaUsada);

            if (senha == senhaUsuario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
