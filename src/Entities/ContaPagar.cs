using PDV.Enums;
using System.Security.Cryptography.Xml;

namespace PDV.Entities
{
    public class ContaPagar
    {

        public int Id_conta_pagar { get; set; }
        public int Id_fornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public double Valor_pago { get; set; } // o valor que foi pago.
        public double Valor_pagamento { get; set; } // o valor que deveria pagar
        public DateTime Data_lancamento { get; set; }
        public DateTime Data_vencimento { get; set; }
        public DateTime Data_pagamento { get; set; }

        public ContaPagar()
        {
            
        }

        public ContaPagar(int id_fornecedor, double valor_pago, double valor_pagamento, DateTime data_lancamento, DateTime data_vencimento, DateTime data_pagamento)
        {
            Id_fornecedor = id_fornecedor;
            Valor_pago = valor_pago;
            Valor_pagamento = valor_pagamento;
            Data_lancamento = data_lancamento;
            Data_vencimento = data_vencimento;
            Data_pagamento = data_pagamento;
            Descricao = EStatusConta.ABERTO.ToString();
        }
    }
}
