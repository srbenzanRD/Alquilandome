﻿namespace Alquilandome.Data.Response
{
    // Clase AlquilerDetalle
    public class AlquilerDetalleResponse
    {
        public int Id { get; set; }
        public int AlquilerId { get; set; }
        public int ArticuloId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioAlquiler { get; set; }
    }

}
