using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Bianhao { get; set; } = null!;
        public string CodigoAnte { get; set; } = null!;
        public int Multi { get; set; }
        public string Namecn { get; set; } = null!;
        public string Namees { get; set; } = null!;
        public string Py { get; set; } = null!;
        public string MuluId { get; set; } = null!;
        public string SubMuluId { get; set; } = null!;
        public decimal Jinjia { get; set; }
        public decimal Maijia { get; set; }
        public decimal Maijia2 { get; set; }
        public decimal Maijia3 { get; set; }
        public decimal Des { get; set; }
        public decimal Des2 { get; set; }
        public decimal Des3 { get; set; }
        public string Changjia { get; set; } = null!;
        public decimal Baozhuangshu { get; set; }
        public decimal Zhuangxiangshu { get; set; }
        public decimal Kucun { get; set; }
        public decimal Kucun2 { get; set; }
        public string KucunWeizhi { get; set; } = null!;
        public int Min { get; set; }
        public int Max { get; set; }
        public string Weizhi { get; set; } = null!;
        public int Jinyong { get; set; }
        public int Tuijian { get; set; }
        public int Cuxiao { get; set; }
        public string Attributes { get; set; } = null!;
        public string Beizhu { get; set; } = null!;
        public string Beizhu2 { get; set; } = null!;
        public DateTime Riqi { get; set; }
        public DateTime FechaC { get; set; }
        public DateTime Fecha { get; set; }
        public int Px { get; set; }
        public int Px2 { get; set; }
        public int Status { get; set; }
        public DateTime FechaActualizar { get; set; }
    }
}
