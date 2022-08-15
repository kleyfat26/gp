using System;
using System.Collections.Generic;

namespace gestionPedidos.Models
{
    public partial class Operador
    {
        public int Codigo { get; set; }
        public string? Usuario { get; set; }
        public string? Nombre { get; set; }
        public string? Sexo { get; set; }
        public string? Clave { get; set; }
        public string? Activado { get; set; }
        public string? Nivel { get; set; }
        public int? Administrador { get; set; }
        public int? Superusuario { get; set; }
        public int? Oficina { get; set; }
        public int? Almacen { get; set; }
        public int? Caja { get; set; }
        public int? Embalaje { get; set; }
        public int? Conductor { get; set; }
        public int? Operadortoro { get; set; }
        public int? Informes { get; set; }
        public int? Pedidosalmacen { get; set; }
        public int? Pedidostienda { get; set; }
        public int? Pedidoleon { get; set; }
        public int? Recogida { get; set; }
        public string? Empresa { get; set; }
        /// <summary>
        /// habilita el boton para que pase los pedidos a caja y embalaje
        /// </summary>
        public int? ExpandirPedido { get; set; }
    }
}
