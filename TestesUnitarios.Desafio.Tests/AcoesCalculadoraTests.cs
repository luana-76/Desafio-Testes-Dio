using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class AcoesCalculadoraTests
{
    
    private AcoesCalculadora _validacoes = new AcoesCalculadora("16/05/2024");

    [Theory]
    [InlineData( 12, 24, 36)]
    [InlineData( 45, 24, 69)]
    public void DeveRetornarASoma(int val1, int val2, int res)
    {
       
        var resultado = _validacoes.Soma(val1, val2);

        Assert.Equal(res, resultado);

    }

    [Theory]
    [InlineData( 134, 15, 119)]
    [InlineData( 12, 15, -3)]
    public void DeveRetornarASubtracao(int val1, int val2, int res)
    {
  
        var resultado = _validacoes.Subtracao(val1, val2);

        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData( 12, 2, 6)]
    [InlineData( 60, 5, 12)]
    public void DeveRestornarADivisao(int val1, int val2, int res)
    {

        
        var resultado = _validacoes.Divisao(val1, val2);
        Assert.Equal(res, resultado);

    }

    [Fact]
    public void TestarDivisãoPorZero()
    {

        Assert.Throws<DivideByZeroException>(
            
            () => _validacoes.Divisao(3, 0)
            
        );

    }

    [Theory]
    [InlineData( 45, 3, 135)]
    [InlineData( 5, 10, 50)]
    public void DeveRetornarAMultiplicacao(int val1, int val2, int res)
    {


        var resultado = _validacoes.Multiplicacao(val1, val2);
        Assert.Equal(resultado, res);

    }

    [Fact]
    public void TestarHistorico()
    {

        _validacoes.Soma(1, 2);
        _validacoes.Soma(4, 10);
        _validacoes.Soma(4, 15);

        var lista = _validacoes.Historico();

        Assert.NotEmpty(lista);

        Assert.Equal(3, lista.Count);

    }

}
