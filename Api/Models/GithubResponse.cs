using System;

namespace githubResponse.Models
{
    public class GithubResponse
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
        [JsonProperty("tirulo_repositorio")]
        public string TituloRepositorio { get; set; }
        [JsonProperty("subtitulo_repositorio")]
        public string SubtituloRepositorio { get; set; }
        [JsonProperty("data_criacao")]
        public string DataCriacaoRepositorio { get; set; }
        [JsonProperty("language_repositorio")]
        public string LanguageRepositorio { get; set; }
    }
}