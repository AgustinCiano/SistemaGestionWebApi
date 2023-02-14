﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionWebApi.Modelos
{
    public class ProductoVendido
    {
        private long id;
        private int stock;
        private long idProducto;
        private long idVenta;


        public long Id { get => id; set => id = value; }
        public int Stock { get => stock; set => stock = value; }
        public long IdProducto { get => idProducto; set => idProducto = value; }
        public long IdVenta { get => idVenta; set => idVenta = value; }

        public ProductoVendido(long id, int stock, long idProducto, long idVenta)
        {
            this.id = id;
            this.stock = stock;
            this.idProducto = idProducto;
            this.idVenta = idVenta;
        }
        public ProductoVendido() { }


    }
}
