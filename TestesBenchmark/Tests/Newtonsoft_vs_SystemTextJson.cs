using BenchmarkDotNet.Attributes;
using TestesBenchmark.Models;

namespace TestesBenchmark.Tests
{
    public class Newtonsoft_vs_SystemTextJson
    {
        private Regiao[] _regioes;

        [GlobalSetup]
        public void Setup()
        {
            _regioes = new Regiao[]
            {
                new () { Codigo = "CO", Nome = "Centro-Oeste" },
                new () { Codigo = "NE", Nome = "Nordeste" },
                new () { Codigo = "N", Nome = "Norte" },
                new () { Codigo = "SE", Nome = "Sudeste" },
                new () { Codigo = "S", Nome = "Sul" }
            };
        }

        [Benchmark]
        public string SerializeWithNewtonsoft()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(_regioes);
        }

        [Benchmark]
        public string SerializeWithSystemTextJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(_regioes);
        }
    }
}