using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Pedidomov
    {
        public int Id { get; set; }
        public string PedidoKey { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Namecn { get; set; } = null!;
        public string Namees { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Bianhao { get; set; } = null!;
        public decimal Jianshu { get; set; }
        public decimal Baozhuangshu { get; set; }
        public decimal Zhuangxiangshu { get; set; }
        public decimal Zongshuliang { get; set; }
        public decimal Precio { get; set; }
        public decimal Des { get; set; }
        public string Beizhu { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Empresa { get; set; }
    }
}
