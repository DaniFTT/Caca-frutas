using Caça_frutas.Interfaces;
using Caça_frutas.Models;
using System;
using System.IO;
using System.Collections.Generic;


namespace Caça_frutas.Utilities
{
    public static class GlobalVariables
    {
        /// <summary>
        /// Variaveis Globais que serão utilizadas ao longo da aplicação
        /// </summary>
        public static string FilePath = $"{AppDomain.CurrentDomain.BaseDirectory}Usuarios.json";
        public static List<Jogador> ListaDeUsuarios = JsonFileHandler.ObterListaDeUsuarios(FilePath);
        public static Jogador JogadorAtual;
        public static Administrador AdministradorAtual = new Administrador("Admin", 20, PasswordHandler.HashSenha("6140"));

    }    
}
