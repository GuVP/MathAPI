using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace MathAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacoesController : ControllerBase
    {
        
        [HttpGet("Soma/{elementoA}/{elementoB}")]
        public IActionResult Soma(double elementoA, double elementoB){
            Soma soma = new Soma
            {
                SomaAB = elementoA + elementoB,
                AceitaComutativa = true
            };
            
            return  Ok(soma);
        }

        [HttpGet("Subtracao/{elementoA}/{elementoB}")]
        public IActionResult Subtracao(double elementoA, double elementoB)
        {
            Subtracao subtracao = new Subtracao
            {
                SubtracaoAB = elementoA - elementoB,
                SubtracaoBA = elementoB - elementoA,
                AceitaComutativa = false
            };

            return Ok(subtracao);
        }

        [HttpGet("Divisao/{elementoA}/{elementoB}")]
        public IActionResult Divisao(double elementoA, double elementoB){
            Divisao divisao = new Divisao
            {
                DivisaoAB = elementoA / elementoB,
                DivisaoBA = elementoB / elementoA,
                AceitaComutativa = false
            };

            return Ok(divisao);
        }

        [HttpGet("Multiplicacao/{elementoA}/{elementoB}")]
        public IActionResult Multiplicacao(double elementoA, double elementoB){
            Multiplicacao multiplicacao = new Multiplicacao
            {
                MultiplicacaoAB = elementoA * elementoB,
                AceitaComutativa = true
            };

            return Ok(multiplicacao);
        }

        [HttpGet("Potenciacao/{elementoBase}/{expoente}")]
        public IActionResult Potenciacao(double elementoBase, double expoente)
        {
            Potenciacao potenciacao = new Potenciacao
            {
                potenciacaoAB = Math.Pow(elementoBase, expoente),
                AceitaComutativa = false
            };

            return Ok(potenciacao);
        }

        [HttpGet("Radiciacao/{elementoRadicando}/{radical}")]
        public IActionResult Radiciacao(double elementoRadicando, double radical)
        {
            Radiciacao radiciacao = new Radiciacao
            {
                RadiciacaoAB = Math.Pow(elementoRadicando, 1/radical),
                AceitaComutativa = false
            };

            return Ok(radiciacao);
        }
    }
}