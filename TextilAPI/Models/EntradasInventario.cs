namespace TextilSwagger.Models
{
    public class EntradasInventario
    {
        public int entradaid { get; set; }
        public DateTime fechaentrada {  get; set; }
        public int productoid {  get; set; }
        public int cantidad { get; set; }
        public int proveedorid { get; set; }
        public int almacenid {  get; set; }

    }
}
