using System.Collections.Generic;
using System.IO;
using Caça_frutas.Models;
using Caça_frutas.Interfaces;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System;
using Caça_frutas.Utilities;

namespace Caça_frutas
{

    public static class JsonFileHandler
    {

        /// <summary>
        /// Metodo responsavel por obter a lista de Jogadores baseado no caminho do arquivo
        /// caso não exista nenhum jogador cadastrado, ele inicializa uma lista vazia
        /// </summary>
        /// <param name="filePath">caminho no qual está o arquivo jogadores.json</param>
        /// <returns>Lista de jogadores</returns>
        public static List<Jogador> ObterListaDeUsuarios(string filePath)
        {
            string json = File.ReadAllText(filePath);
                      
            List<Jogador> users;
            if (json.Length == 0)
            {
                users = new List<Jogador>();
            }
            else
            {
                users = JsonConvert.DeserializeObject<List<Jogador>>(json);
            }

            return users;
        }


        /// <summary>
        /// Salva/Atualiza lista de jogadores no caminho de arquivo desejado
        /// </summary>
        /// <param name="filePath">caminho para qual o arquivo será salvo</param>
        /// <param name="Usuarios">Lista de jogadores que seram salvos no arquivo json</param>
        /// <param name="indent">Booleano que dirá se o arquivo deverá ser identado(true) ou não(false)</param>
        public static void SalvarLista(string filePath, List<Jogador> Usuarios, bool indent)
        {
            Formatting formatacao = indent ? Formatting.Indented : Formatting.None;
            var json = JsonConvert.SerializeObject(Usuarios, formatacao);
            File.WriteAllText(filePath, json);
        }
    }

}