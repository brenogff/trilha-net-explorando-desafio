namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
        
            //IMPLEMENTADO.
            if (hospedes.Count <= Suite.Capacidade)
                {
                    Hospedes = hospedes;
                }
                else
                {
                
                //IMPLEMENTADO
                Console.WriteLine("O numero de hospesdes e maior que o numero permitido na suite");
            }
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //IMPLEMENTADO

            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            //IMPLEMENTADO
            decimal valorDiaria = DiasReservados * Suite.ValorDiaria;
           
            decimal valor = valorDiaria;

            //IMPLEMENTADO
            if (DiasReservados >= 10)
            {
                valor = valor - ((valor * 10) / 100);
            }

            return valor;
        }
    }
}