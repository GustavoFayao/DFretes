using CustoFreteAPI.Models;

namespace CustoFreteAPI.Services
{
    public class CalculoCombustivelService
    {
        public CustoViagemResponse Calcular(CustoViagemRequest request)
        {
            double litros = request.DistanciaKm / request.ConsumoKmPorLitro;
            double custo = litros * request.PrecoCombustivel;

            return new CustoViagemResponse
            {
                LitrosNecessarios = litros,
                CustoTotal = custo
            };
        }
    }
}
