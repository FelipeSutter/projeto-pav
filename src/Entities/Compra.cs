using PDV.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Entities
{
    public class Compra
    {
        public int Id_compra { get; set; }
        public DateTime Data_Hora { get; set; }
        public double Total_Compra{ get; set; }
        public EStatus Situacao_Compra { get; set; }
        public int Id_fornecedor{ get; set; }
        public Fornecedor fornecedor { get; set; }

        public Compra()
        {

        }

        public Compra(double totalCompra, EStatus situacaoCompra, int id_fornecedor)
        {
            Total_Compra = totalCompra;
            Situacao_Compra = situacaoCompra;
            Id_fornecedor = id_fornecedor;
            Data_Hora = DateTime.Now;
        }
    }

}
